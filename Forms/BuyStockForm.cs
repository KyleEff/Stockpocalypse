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
        }

        private void SetTotal() {

            string PriceString = "";

            if (PriceTextBox.Text != null)
                for (var letter = 1; letter < PriceTextBox.Text.Length; letter++)
                    PriceString += PriceTextBox.Text[letter];

            _price = Convert.ToDouble(PriceString);
            //MessageBox.Show(PriceString);

            if (!QuantityTextBox.Text.Equals("0") && !QuantityTextBox.Text.Equals("")) {

                TotalTextBox.Text = (Convert.ToDouble(PriceString) * Convert.ToDouble(QuantityTextBox.Text)).ToString("C2");

                PriceString = "";
                for (var letter = 1; letter < TotalTextBox.Text.Length; letter++)
                        PriceString += TotalTextBox.Text[letter];

                _total = Convert.ToDouble(PriceString);

                if (Convert.ToDouble(PriceString) > Dashboard.Cash)
                    MessageBox.Show("There is not enough cash in your account to accommodate this order!!");
            }
            else TotalTextBox.Text = "$0.00";
        }   

        private void BuyButton_Click(object sender, EventArgs e)
        {
            DBWires.DataAccess Database = new DBWires.DataAccess();

            if (_total <= Dashboard.Cash)
            {
                Database.SendOrder(
                    true,
                    SymbolTextBox.Text,
                    NameTextBox.Text,
                    _price,
                    Convert.ToInt32(QuantityTextBox.Text)
               );

                Dashboard.Cash -= _total;
                _mainForm.WriteCash();
            }
            else MessageBox.Show("There are not enough funds in your account to execute this order!!");

            CashTextBox.Text = _mainForm.CashBox;
            OrderResultsTextBox.Text = Database.ViewMostRecentOrder()[0].FullInfo;
        }

        private void DepositCashButton_Click(object sender, EventArgs e)
        {
            if (_mainForm != null) { _mainForm.DepositCash(); }
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }
    }
}
