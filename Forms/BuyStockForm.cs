using System;
using System.Windows.Forms;
using StockForms.DBWires;
using StockForms.Interfaces;

namespace StockForms.Forms
{
    /*
     * This form runs all purchase transactions,
     *  interacting with both the API and the database.
     *  
     * _price stores the executing price of the order.
     * _total stores the total price of the order (quantity * price)
     * _mainForm stores the Dashboard
     */

    public partial class BuyStockForm : Form, ITransaction
    {
        private double _price { get; set; }
        private double _total { get; set; }
        private Dashboard _mainForm = null;

        // Constructors
        public BuyStockForm()
        {
            InitializeComponent();
        }

        public BuyStockForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;
            InitializeComponent();

            CashTextBox.Text = _mainForm.CashBox;
            _mainForm.Hide();
        }

        /* This function sets the total of the order (price * quantity) */
        public void SetTotal() {

            string PriceString = "";
            // Check the pricebox for a dollar sign and then assign the price
            if (PriceTextBox.Text != null) {

                if (PriceTextBox.Text[0] == '$')
                    for (var letter = 1; letter < PriceTextBox.Text.Length; letter++)
                    PriceString += PriceTextBox.Text[letter];
                else PriceString = PriceTextBox.Text;
            }

            _price = Convert.ToDouble(PriceString);
            //MessageBox.Show(PriceString);

            // If the quantity box is not empty
            if (!QuantityTextBox.Text.Equals("0") && !QuantityTextBox.Text.Equals("")) {

                // Does the math to calculate the total
                TotalTextBox.Text = (Convert.ToDouble(PriceString) * Convert.ToDouble(QuantityTextBox.Text)).ToString("C2");

                // This loop removes the dollar sign and stores the total
                PriceString = "";
                for (var letter = 1; letter < TotalTextBox.Text.Length; letter++)
                        PriceString += TotalTextBox.Text[letter];

                _total = Convert.ToDouble(PriceString);

                // If the order total is greater than the amount of cash, kick a message
                if (_total > Dashboard.Cash)
                    MessageBox.Show("There is not enough cash in your account to accommodate this order!!");
            }
            // Display zero if there is no quantity
            else TotalTextBox.Text = "$0.00";
        }   

        /* 
         * This function runs the transaction, using the data to create an order
         *  that is sent to the database, and then the user's portfolio is changed
         *  depending on the contents of the order.
         */
        public void Transact()
        {
            // BUY BUY BUY
            // Create a database object and fill in an order object with the order information
            DataAccess Database = new DataAccess();
            Order order = new Order() {

                Buy = true,
                Stock_Ticker = "'" + SymbolTextBox.Text + "'",
                Stock_Name = "'" + NameTextBox.Text + "'",
                Price = _price,
                Quantity = Convert.ToInt32(QuantityTextBox.Text)
            };

            //MessageBox.Show(order.FullInfo);

            // Check if the total of the order is less than or equal to the user's cash
            if (_total <= Dashboard.Cash)
            {
                /*
                Database.SendOrder(true,
                    "'" + SymbolTextBox.Text + "'",
                    "'" + NameTextBox.Text + "'",
                    _price,
                    Convert.ToInt32(QuantityTextBox.Text)
                );*/
                // Send order to database
                Database.SendOrder(order);

                // Change portfolio
                Database.AlterPortfolio(order);

                // Subtract cash and write to file
                Dashboard.Cash -= _total;
                _mainForm.WriteCash();

                // Show order results
                OrderResultsTextBox.Text = Database.ViewMostRecentOrder()[0].FullInfo;
            }
            else {
                // If there is not enough cash, kick a message and fail the order.
                MessageBox.Show("There are not enough funds in your account to execute this order!!");

                OrderResultsTextBox.Text = "ORDER FAILED";
            }

            // Set the cash display
            CashTextBox.Text = _mainForm.CashBox;
        }

        // EVENTS
        private void BuyButton_Click(object sender, EventArgs e) => Transact(); 

        private void QuoteButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenQuoteWindow();
            Close();
        }

        private void DepositCashButton_Click(object sender, EventArgs e) {
        
            if (_mainForm != null) _mainForm.DepositCash();
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This software is being developed by:\n" +
                "KFree, LLC\n" +
                "2022"
            );
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenSearchWindow();
        }

        private void QuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenQuoteWindow();
        }

        private void BuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenBuyWindow();
        }

        private void SellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenSellWindow();
        }

        private void PortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenPortfolioWindow();
        }

        private void BuyForm_Closing(object sender, FormClosingEventArgs e)
        {
            _mainForm.BuyStockWin = null;
            _mainForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All currency is in United States Dollars.");
        }
    }
}
