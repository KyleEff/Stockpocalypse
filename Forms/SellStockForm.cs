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
            //FillPortfolioList();
            _mainForm.Hide();
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
                
                // Add portfolio alter here

                Dashboard.Cash += _total;
                _mainForm.WriteCash();
            }
            else MessageBox.Show("There are not enough funds in your account to execute this order!!");

            CashTextBox.Text = _mainForm.CashBox;
            OrderResultsTextBox.Text = Database.ViewMostRecentOrder()[0].FullInfo;
        }

        private void FillPortfolioList() { 

            DataAccess database = new DataAccess();

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
            Dashboard.Client = new HttpClient();
            Dashboard.Api = new TwelveDataClient(Dashboard.ApiKey, Dashboard.Client);

            var price = await Dashboard.Api.GetRealTimePriceAsync(SymbolTextBox.Text);

            PriceTextBox.Text = price.Price.ToString("C2");
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

        private void PortfolioDataGridView_CellContentClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = _portfolioDataGridView.SelectedRows[0].DataBoundItem as Customer_Portfolio;

                SymbolTextBox.Text = selectedRow.Stock_Ticker;
                NameTextBox.Text = selectedRow.Stock_Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
