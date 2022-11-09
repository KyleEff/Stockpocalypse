using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        private double _price { get; set; }
        private double _total { get; set; }
        Dashboard _mainForm = null;

        List<Customer_Portfolio> _portfolio = null;

        public SellStockForm()
        {
            InitializeComponent();
        }

        public SellStockForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;

            InitializeComponent();
            //FillPortfolioList();
            CashTextBox.Text = _mainForm.CashBox;
            _mainForm.Hide();
        }

        public void SetTotal() {

            string PriceString = "";

            if (PriceTextBox.Text != null)
            {
                if (PriceTextBox.Text[0] == '$')
                    for (var letter = 1; letter < PriceTextBox.Text.Length; letter++)
                        PriceString += PriceTextBox.Text[letter];
                else PriceString = PriceTextBox.Text;
            }

            _price = Convert.ToDouble(PriceString);
            //MessageBox.Show(PriceString);

            if (!QuantityTextBox.Text.Equals("0") && !QuantityTextBox.Text.Equals(""))
            {

                TotalTextBox.Text = (Convert.ToDouble(PriceString) * Convert.ToDouble(QuantityTextBox.Text)).ToString("C2");

                // REUSED STRING
                PriceString = "";
                for (var letter = 1; letter < TotalTextBox.Text.Length; letter++)
                    PriceString += TotalTextBox.Text[letter];

                _total = Convert.ToDouble(PriceString);


            }
            else TotalTextBox.Text = "$0.00";
        }

        public void Transact() {
            // SELL SELL SELL

            var Database = new DataAccess();
            string PriceString = "";

            if (PriceTextBox.Text != null)
            {
                if (PriceTextBox.Text[0] == '$')
                    for (var letter = 1; letter < PriceTextBox.Text.Length; letter++)
                        PriceString += PriceTextBox.Text[letter];
                else PriceString = PriceTextBox.Text;
            }

            Order order = new Order() {

                Buy = false,
                Stock_Ticker = SymbolTextBox.Text,
                Stock_Name = NameTextBox.Text,
                Price = Convert.ToDouble(PriceString),
                Quantity = Convert.ToInt32(QuantityTextBox.Text)
            };

            if (order.Total <= Dashboard.Cash)
            {
                /*
                Database.SendOrder(
                    false, // The buy boolean is false because this is a sell order
                    SymbolTextBox.Text,
                    NameTextBox.Text,
                    _price,
                    Convert.ToInt32(QuantityTextBox.Text)
                );*/

                Database.SendOrder(false, order);

                Database.AlterPortfolio(order);

                Dashboard.Cash += order.Total;
                _mainForm.WriteCash();
            }
            else MessageBox.Show("There are not enough funds in your account to execute this order!!");

            CashTextBox.Text = _mainForm.CashBox;
            OrderResultsTextBox.Text = Database.ViewMostRecentOrder()[0].FullInfo;
        }

        private async Task<string> GetPrice(string Ticker)
        {

            //MessageBox.Show("TICKER: " + Ticker);
            if (Ticker != "")
            {
                Dashboard.Api = new TwelveDataClient(
                    Dashboard.ApiKey,
                    Dashboard.Client = new HttpClient()
                );

                // PROBLEM HERE
                var price = await Dashboard.Api.GetRealTimePriceAsync(Ticker);

                return price.Price.ToString("C2");
            }
            else return "0.00";
        }

        private void FillPortfolioList() { 

            var database = new DataAccess();

            _portfolio = database.ViewPortfolio();

            _portfolioDataGridView.DataSource = _portfolio;
        }

        private void SellButton_Click(object sender, EventArgs e) { Transact(); }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTotal();
        }

        private async void PriceButton_Click(object sender, EventArgs e)
        {
            PriceTextBox.Text = await GetPrice(SymbolTextBox.Text);//.Result.ToString();
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

        private void SellStockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.SellStockWin = null;
            _mainForm.Show();
        }

        private void SellStockForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viewPortfolio.portfolio' table. You can move, or remove it, as needed.
            this.portfolioTableAdapter.Fill(this.viewPortfolio.portfolio);
        }

        private void PortfolioDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*
                var selectedRow = _portfolioDataGridView.SelectedRows[0].DataBoundItem as Customer_Portfolio;

                SymbolTextBox.Text = selectedRow.Stock_Ticker;
                NameTextBox.Text = selectedRow.Stock_Name;
                */

                var row = this._portfolioDataGridView.Rows[e.RowIndex].Cells;

                SymbolTextBox.Text = row[1].Value.ToString();
                NameTextBox.Text = row[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All currency is in United States Dollars.");
        }


    }
}
