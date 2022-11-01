using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockForms.DBWires;
using StockForms.Interfaces;
using TwelveDataSharp;

namespace StockForms.Forms
{
    public partial class SellStockForm : Form, ITransaction
    {
        double _price { get; set; }
        double _total { get; set; }

        Dashboard _mainForm = null;

        List<Customer_Portfolio> _portfolio = null;

        public SellStockForm()
        {
            InitializeComponent();
        }

        public SellStockForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;

            InitializeComponent();
            FillPortfolioList();
        }

        public void SetTotal() {

            string PriceString = "";

            if (PriceTextBox.Text != null)
                for (var letter = 1; letter < PriceTextBox.Text.Length; letter++)
                    PriceString += PriceTextBox.Text[letter];

            _price = Convert.ToDouble(PriceString);
            //MessageBox.Show(PriceString);

            if (!QuantityTextBox.Text.Equals("0") && !QuantityTextBox.Text.Equals(""))
            {

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

        public void Transact() {
            // SELL SELL SELL

            DataAccess Database = new DataAccess();

            if (_total <= Dashboard.Cash)
            {
                Database.SendOrder(
                    false, // The buy boolean is false because this is a sell order
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

        private void FillPortfolioList() { 

            DataAccess database = new DataAccess();

            _portfolio = database.ViewPortfolio();

            _portfolioResultListBox.DataSource = _portfolio;
            _portfolioResultListBox.DisplayMember = "FullInfo";
        }

        private void SellButton_Click(object sender, EventArgs e) { Transact(); }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }

        private void PortfolioResultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SymbolTextBox.Text = _portfolio[_portfolioResultListBox.SelectedIndex].Stock_Ticker;
            NameTextBox.Text = _portfolio[_portfolioResultListBox.SelectedIndex].Stock_Name;
        }

        private async void PriceButton_Click(object sender, EventArgs e)
        {
            Dashboard.Client = new HttpClient();
            Dashboard.Api = new TwelveDataClient(Dashboard.ApiKey, Dashboard.Client);

            var price = await Dashboard.Api.GetRealTimePriceAsync(SymbolTextBox.Text);

            PriceTextBox.Text = price.Price.ToString("C2");
        }
    }
}
