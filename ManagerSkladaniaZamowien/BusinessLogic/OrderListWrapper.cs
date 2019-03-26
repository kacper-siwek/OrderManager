using OrderSubmissionManager;
using OrderSubmissionManager.BusinessLogic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ManagerSkladaniaZamowien.BusinessLogic
{
    /// <summary>
    /// This class was created in order to serialize Orders and OrderItems. Unqiue classes were created for this
    /// purpose - OrderSerializable and OrderItemSerializable, in order to work around the fact that they implement
    /// interfaces, which didn't allow the objects of these classes to be serialized.
    /// </summary>
    [XmlRoot("ArrayList")]
    public class OrderListWrapper
    {
        [XmlElement(Type = typeof(OrderSerializable)),
        XmlElement(Type = typeof(OrderItemSeralizable))]

        public ArrayList list = new ArrayList();

        public OrderListWrapper()
        {
            var instance = OrderManager.Instance;



            OrderSerializable orderSerializable = new OrderSerializable
            {
                Name = instance.CurrentOrder.Name,
                Surname = instance.CurrentOrder.Surname,
                BirthDate = instance.CurrentOrder.BirthDate
            };

            list.Add(orderSerializable);
            foreach (OrderItem item in instance.OrderList)
            {
                var orderItem = new OrderItemSeralizable
                {
                    ItemName = item.ItemName,
                    Amount = item.Amount,
                    Price = item.Price
                };

                list.Add(orderItem);
            }
        }
    }
}
