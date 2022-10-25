using StockForms.ResultModels;
using System;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;
using TwelveDataSharp;
using TwelveDataSharp.Library.ResponseModels;

namespace StockForms.Forms
{
    public partial class QuoteForm : Form
    {
        public string Exchange { get; set; }
        public string Symbol { get; set; }
        StockListModel _stocks { get; set; }
        Dashboard _mainForm = null;

        public QuoteForm()
        {
            InitializeComponent();
            FillStockList();
        }

        public QuoteForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;

            InitializeComponent();
            FillStockList();
        }



        private async void FillStockList() {

            if (_stocks == null)
                _stocks = await StockForms.Extra_API.ApiProcessor.LoadStockList("NYSE");
            else
                _stocks = await StockForms.Extra_API.ApiProcessor.LoadStockList(Exchange);

            if (_stocks != null)
            {
                StockListBox.DataSource = _stocks.Data;
                StockListBox.DisplayMember = "FullInfo";
            }
            else MessageBox.Show("OOOOOOOOOOOOOOOOOOOOOOOOOOPS");
        }

        private async void GetQuoteButton_Click(object sender, EventArgs e)
        {
            Dashboard.Client = new HttpClient();
            Dashboard.Api = new TwelveDataClient(Dashboard.ApiKey, Dashboard.Client);

            var Quote = await Dashboard.Api.GetQuoteAsync(Symbol);

            DateTimeBox.Text = Quote.Datetime.ToString();
            PriceBox.Text = Quote.Close.ToString("C2");
            DailyHigh.Text = Quote.FiftyTwoWeekHigh.ToString("C2");
            DailyLow.Text = Quote.FiftyTwoWeekLow.ToString("C2");
        }

        private void NyseRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            Exchange = NyseRadioButton.Text;
            FillStockList();
        }

        private void NasdaqRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            Exchange = NasdaqRadioButton.Text;
            FillStockList();
        }

        private void StockListBox_MouseClick(object sender, MouseEventArgs e)
        {
            Symbol = _stocks.Data[StockListBox.SelectedIndex].Symbol;
            //MessageBox.Show(Symbol);
        }

        private async void BuyStockButton_Click(object sender, EventArgs e)
        {
            Dashboard.Client = new HttpClient();
            Dashboard.Api = new TwelveDataClient(Dashboard.ApiKey, Dashboard.Client);
            var BuyForm = new BuyStockForm(_mainForm);
            var Quote = await Dashboard.Api.GetQuoteAsync(Symbol);

            BuyForm.SymbolTextBox.Text = Symbol;
            BuyForm.NameTextBox.Text = Quote.Name;
            BuyForm.PriceTextBox.Text = Quote.Close.ToString("C2");

            BuyForm.Show();
        }
    }
}
