using System;
using System.Windows.Forms;
using StockForms.DBWires;

namespace StockForms.Forms
{
    public partial class BuyStockForm : Form
    {
        private double _price { get; set; }
        private double _total { get; set; }
        private Dashboard _mainForm = null;

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

        public void SetTotal() {

            string PriceString = "";

            if (PriceTextBox.Text != null) {

                if (PriceTextBox.Text[0] == '$')
                    for (var letter = 1; letter < PriceTextBox.Text.Length; letter++)
                    PriceString += PriceTextBox.Text[letter];
                else PriceString = PriceTextBox.Text;
            }

            _price = Convert.ToDouble(PriceString);
            //MessageBox.Show(PriceString);

            if (!QuantityTextBox.Text.Equals("0") && !QuantityTextBox.Text.Equals("")) {

                TotalTextBox.Text = (Convert.ToDouble(PriceString) * Convert.ToDouble(QuantityTextBox.Text)).ToString("C2");

                PriceString = "";
                for (var letter = 1; letter < TotalTextBox.Text.Length; letter++)
                        PriceString += TotalTextBox.Text[letter];

                _total = Convert.ToDouble(PriceString);

                if (_total > Dashboard.Cash)
                    MessageBox.Show("There is not enough cash in your account to accommodate this order!!");
            }
            else TotalTextBox.Text = "$0.00";
        }   

        public void Transact()
        {
            // BUY BUY BUY
            DataAccess Database = new DataAccess();
            Order order = new Order() {

                Buy = true,
                Stock_Ticker = "'" + SymbolTextBox.Text + "'",
                Stock_Name = "'" + NameTextBox.Text + "'",
                Price = _price,
                Quantity = Convert.ToInt32(QuantityTextBox.Text)
            };

            //MessageBox.Show(order.FullInfo);

            if (_total <= Dashboard.Cash)
            {
                Database.SendOrder(true, order);

                /*
                Database.SendOrder(true,
                    "'" + SymbolTextBox.Text + "'",
                    "'" + NameTextBox.Text + "'",
                    _price,
                    Convert.ToInt32(QuantityTextBox.Text)
                );*/

                Database.AlterPortfolio(order);

                Dashboard.Cash -= _total;
                _mainForm.WriteCash();
            }
            else MessageBox.Show("There are not enough funds in your account to execute this order!!");

            CashTextBox.Text = _mainForm.CashBox;
            OrderResultsTextBox.Text = Database.ViewMostRecentOrder()[0].FullInfo;
        }

        private void BuyButton_Click(object sender, EventArgs e) { Transact(); }

        private void QuoteButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenQuoteWindow();
        }

        private void DepositCashButton_Click(object sender, EventArgs e)
        {
            if (_mainForm != null) { _mainForm.DepositCash(); }
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
