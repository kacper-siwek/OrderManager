using OrderSubmissionManager.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSubmissionManager
{
    public partial class OrderItemEditionForm : Form
    {
        #region Constructors
        public OrderItemEditionForm()
        {
            InitializeComponent();

            FormMode = "add";
            SubmitButton.Text = "Dodaj";
        }
        public OrderItemEditionForm(int rowIndex) : this()
        {
            this.FormMode = "change";
            this.RowIndex = rowIndex;
            SubmitButton.Text = "Aktualizuj";

            var orderItem = OrderManager.Instance.OrderList.ElementAt(RowIndex);
            ItemNameTextBox.Text = orderItem.ItemName;
            AmountTextBox.Text = orderItem.Amount.ToString();
            PriceTextBox.Text = orderItem.Price.ToString();
        }
        #endregion

        #region Properties
        private string FormMode { get; set; }
        private int RowIndex { get; set; }
        #endregion

        #region Methods
        private bool ValidateTextBoxes()
        {
            bool ValidationFlag = true;
            // ValidationFlag holds the information about whether the tests have passed or not. It is 'true' by default, but 
            // it changes to 'false' as soon as one or more regex tests come back as false.

            // Regex patterns for checking user input.
            string ItemNamePattern = @"\S+";
            string NumericPattern = @"(^\d+$)|(^\d+,\d+$)";

            // Matching user values:
            bool isItemNameValid = Regex.IsMatch(ItemNameTextBox.Text, ItemNamePattern);
            bool isAmountValid = Regex.IsMatch(AmountTextBox.Text, NumericPattern);
            bool isPriceValid = Regex.IsMatch(PriceTextBox.Text, NumericPattern);

            if (!isItemNameValid)
            {
                MessageBox.Show("Nie podano nazwy przedmiotu lub podano niewłaściwą nazwę.");
                ValidationFlag = false;
            }
            else if (!isAmountValid)
            {
                MessageBox.Show("Podano błędną ilość produktu. \n\nPrzypomnienie: separatorem dziesiętnym jest przecinek.");
                ValidationFlag = false;
            }
            else if (!isPriceValid)
            {
                MessageBox.Show("Podano błędną cenę produktu. \n\nPrzypomnienie: separatorem dziesiętnym jest przecinek.");
                ValidationFlag = false;
            }
            return ValidationFlag;
        }
        #endregion

        #region Buttons
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                var instance = OrderManager.Instance;
                string itemName = ItemNameTextBox.Text;
                //ok
                double amount = Convert.ToDouble(AmountTextBox.Text);
                decimal price = Convert.ToDecimal(PriceTextBox.Text);

                if (FormMode == "add")
                {
                    instance.AddItem(itemName, amount, price);

                    ItemNameTextBox.Clear();
                    AmountTextBox.Clear();
                    PriceTextBox.Clear();
                }
                else if (FormMode == "change")
                {
                    instance.UpdateItemAt(this.RowIndex, itemName, amount, price);
                    ExitButton_Click(this, new EventArgs());
                }
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void OrderItemEditionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
