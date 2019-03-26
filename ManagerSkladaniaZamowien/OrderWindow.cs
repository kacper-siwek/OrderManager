using OrderSubmissionManager.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSubmissionManager
{
    public partial class OrderWindow : Form
    {
        #region Constructors
        public OrderWindow()
        {
            InitializeComponent();
            Table = new DataTable();

            var instance = OrderManager.Instance;
            instance.CollectionChangedEvent += Instance_CollectionChangedEvent;
            instance.OrderSavedEvent += Instance_OrderSavedEvent;
        }

        
        #endregion

        #region Properties
        private DataTable Table { get; set; }
        #endregion

        #region Methods
        private void Instance_OrderSavedEvent(object sender, EventArgs e)
        {
            // This method is called when an order has been saved. It clears all the data from the DataGridView
            // and the Textboxes.

            Table.Clear();
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            BirthdayTextBox.Clear();
            MessageBox.Show("Poprawnie zapisano zamówienie.");
        }
        private void OrderWindow_Load(object sender, EventArgs e)
        {
            // Settings for the DataGridView. 

            Table = new DataTable();
            Table.Columns.Add("ItemName", typeof(string));
            Table.Columns.Add("Amount", typeof(double));
            Table.Columns.Add("Price", typeof(decimal));
            
            OrderDataGridView.DataSource = Table;
            this.OrderDataGridView.Columns["Amount"].DefaultCellStyle.Format = "N";
            this.OrderDataGridView.Columns["Price"].DefaultCellStyle.Format = "N";
            this.OrderDataGridView.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.OrderDataGridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.OrderDataGridView.MultiSelect = false;

            OrderDataGridView.AllowUserToResizeColumns = true;
            this.OrderDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.OrderDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i < OrderDataGridView.Columns.Count; i++)
            {
                int colw = OrderDataGridView.Columns[i].Width;
                OrderDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                OrderDataGridView.Columns[i].Width = colw;
            }
        }
        private void Instance_CollectionChangedEvent(object sender, EventArgs e)
        {
            // This method is called when a collection of OrderItems has been changed. It reloads the content
            // of the DataGridView.

            Table.Clear();
            var instance = OrderManager.Instance;
            var orderList = instance.OrderList;

            foreach (OrderItem item in orderList)
            {
                Table.Rows.Add(item.ItemName, item.Amount, item.Price);
            }
        }

        private bool ValidateOrder()
        {
            // Validation of the Textboxes.

            bool ValidationFlag = true;
            // ValidationFlag holds the information about whether the tests have passed or not. It is 'true' by default, but 
            // it changes to 'false' as soon as one or more regex tests come back as false.

            // OrderManager instance to check whether there's at least one OrderItem.
            var instance = OrderManager.Instance.OrderList;

            // Regex pattern for checking user input.
            string NamePattern = @"\S+";

            // Matching user values:
            bool isNameValid = Regex.IsMatch(NameTextBox.Text, NamePattern);
            bool isSurnameValid = Regex.IsMatch(SurnameTextBox.Text, NamePattern);
            bool isBirthdayValid = DateTime.TryParse(BirthdayTextBox.Text, CultureInfo.CreateSpecificCulture("pl-PL"),
                                                    DateTimeStyles.AssumeLocal, out DateTime birthday);
            bool hasAtLeastOneOrderItem = instance.Count() > 0 ? true : false;

            if (!isNameValid)
            {
                MessageBox.Show("Podano niewłaściwe imię.");
                ValidationFlag = false;
            }
            else if (!isSurnameValid)
            {
                MessageBox.Show("Podano niewłaściwe nazwisko.");
                ValidationFlag = false;
            }
            else if (!isBirthdayValid || birthday.Year < 1900)
            {
                MessageBox.Show("Podano błędną datę urodzenia. \n\n Przypomnienie: poprawny format daty to" +
                    "'RRRR-MM-DD'. Rok urodzenia musi być większy niż 1900.");
                ValidationFlag = false;
            }
            else if (!hasAtLeastOneOrderItem)
            {
                MessageBox.Show("Należy dodać przynajmniej jeden produkt.");
                ValidationFlag = false;
            }
            return ValidationFlag;
        }

        #endregion

        #region Buttons
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var orderItemWindow = new OrderItemEditionForm();
            orderItemWindow.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.CurrentCell != null)
            {
                var instance = OrderManager.Instance;
                int rowIndex = OrderDataGridView.CurrentCell.RowIndex;
                instance.RemoveItemAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego produktu.");
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (OrderDataGridView.CurrentCell != null)
            {
                int rowIndex = OrderDataGridView.CurrentCell.RowIndex;
                var orderItemWindow = new OrderItemEditionForm(rowIndex);

                orderItemWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego produktu.");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ValidateOrder())
            {
                var instance = OrderManager.Instance;
                var order = instance.CurrentOrder;

                order.Name = NameTextBox.Text;
                order.Surname = SurnameTextBox.Text;
                order.BirthDate = DateTime.Parse(BirthdayTextBox.Text, CultureInfo.CreateSpecificCulture("pl-PL"),
                                                        DateTimeStyles.AssumeLocal);

                try
                {
                    instance.SaveOrder();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void SaveToXML_Button_Click(object sender, EventArgs e)
        {
            if (ValidateOrder())
            {
                var instance = OrderManager.Instance;

                var order = instance.CurrentOrder;

                order.Name = NameTextBox.Text;
                order.Surname = SurnameTextBox.Text;
                order.BirthDate = DateTime.Parse(BirthdayTextBox.Text, CultureInfo.CreateSpecificCulture("pl-PL"),
                                                        DateTimeStyles.AssumeLocal);

                try
                {
                    instance.WriteXML();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
    }
}
