using ManagerSkladaniaZamowien.BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

/// <summary>
/// OrderManager is a singleton.
/// OrderManager is used to create and store instances of Orders and OrderItems and to send
/// them to a database.
/// </summary>

namespace OrderSubmissionManager.BusinessLogic
{
    public sealed class OrderManager
    {

        #region Events
        public event EventHandler<EventArgs> CollectionChangedEvent;
        // Raised whenever a collection of OrderItems is changed.

        public event EventHandler<EventArgs> OrderSavedEvent;
        // Raised when an Order is saved.
        #endregion
        
        #region Properties
        private static readonly OrderManager instance = new OrderManager();
        private Order _order;
        private List<OrderItem> _orderList;

        public Order CurrentOrder
        {
            get { return _order; }
            set { _order = value; }
        }
        public List<OrderItem> OrderList
        {
            get { return _orderList; }
            set { _orderList = value; }
        }
        public static OrderManager Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        #region Methods
        public void AddItem(string itemName, double amount, decimal price)
        {
            // Creates an instance of OrderItem and adds it to the current OrderItem list
            var orderItem = new OrderItem
            {
                ItemName = itemName,
                Amount = amount,
                Price = price,
                Order = this.CurrentOrder
            };
            OrderList.Add(orderItem);

            CollectionChangedEvent?.Invoke(this, new EventArgs());
        }

        public void RemoveItemAt(int index)
        {
            // Removes a given OrderItem from the current OrderItem list.
            OrderList.RemoveAt(index);
            CollectionChangedEvent?.Invoke(this, new EventArgs());
        }
        public void UpdateItemAt(int index, string itemName, double amount, decimal price)
        {
            // Updates a given OrderItem.
            var orderItem = OrderList.ElementAt(index);
            orderItem.ItemName = itemName;
            orderItem.Amount = amount;
            orderItem.Price = price;

            CollectionChangedEvent?.Invoke(this, new EventArgs());
        }

        public void SaveOrder()
        {
            DatabaseEntities context = new DatabaseEntities();

            context.Order.Add(CurrentOrder);
            foreach (OrderItem item in OrderList)
            {
                context.OrderItem.Add(item);
            }

            context.SaveChanges();

            // After an order has been saved a new Order and List of OrderItems is created.
            this.CurrentOrder = new Order();
            this.OrderList = new List<OrderItem>();

            OrderSavedEvent(this, new EventArgs());
        }

        public void WriteXML()
        {
            OrderListWrapper listWrapper = new OrderListWrapper();
            XmlSerializer mySerializer = new XmlSerializer(typeof(OrderListWrapper));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Order.xml";
            StreamWriter streamWriter = new StreamWriter(path);
            mySerializer.Serialize(streamWriter, listWrapper);

            // After an order has been saved a new Order and List of OrderItems is created.
            this.CurrentOrder = new Order();
            this.OrderList = new List<OrderItem>();

            OrderSavedEvent(this, new EventArgs());
        }
        #endregion

        #region Constructors
        static OrderManager()
        {
            // This constructor is created in order to tell the C# compiler not to mark
            // type as beforefieldinit
        }

        private OrderManager()
        {
            CurrentOrder = new Order();
            OrderList = new List<OrderItem>();
        }
        #endregion
    }
}
