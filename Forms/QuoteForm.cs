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
                _stocks = await StockForms.Extra_API.ApiProcessor.LoadStockList();
            else
                _stocks = await StockForms.Extra_API.ApiProcessor.LoadStockList(Exchange);

            if (_stocks != null)
            {
                _stockListBox.DataSource = _stocks.Data;
                _stockListBox.DisplayMember = "FullInfo";
            }
            else MessageBox.Show("OOOOOOOOOOOOOOOOOOOOOOOOOOPS");
        }

        private async void GetQuoteButton_Click(object sender, EventArgs e)
        {
            Dashboard.Client = new HttpClient();
            Dashboard.Api = new TwelveDataClient(Dashboard.ApiKey, Dashboard.Client);

            var Quote = await Dashboard.Api.GetQuoteAsync(Symbol, "1day");

            _dateTimeBox.Text = Quote.Datetime.ToString();
            _priceBox.Text = Quote.Close.ToString("C2");
            _volumeTextBox.Text = Quote.Volume.ToString();
            _dailyHigh.Text = Quote.High.ToString("C2");
            _dailyLowTextBox.Text = Quote.Low.ToString("C2");
            _dailyChangeTextBox.Text = Quote.PercentChange.ToString("0.00") + '%';
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
            Symbol = _stocks.Data[_stockListBox.SelectedIndex].Symbol;
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
