using StockForms.ResultModels;
using System;

using System.Net.Http;
using System.Windows.Forms;
using TwelveDataSharp;

namespace StockForms.Forms
{

    /*
     * This form is for gathering information about a stock,
     *  and enables the user to choose from a list.
     *  
     * Exchange holds the string value of the selected radio button
     * Symbol stores the symbol of the selected stock so it can be used to grab a quote
     * _stocks is used to store the results of the exchange API ping
     * _mainForm stores the Dashboard
     */
    
    public partial class QuoteForm : Form
    {
        public string Exchange { get; set; }
        public string Symbol { get; set; }
        StockListModel _stocks { get; set; }
        Dashboard _mainForm = null;

        // Constructors
        public QuoteForm()
        {
            InitializeComponent();
            FillStockList();
        }

        public QuoteForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;
            _mainForm.Hide();

            InitializeComponent();
            FillStockList();
        }

        /* This function fills the stock list with stocks from the selected exchange */
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

        // EVENTS
        /* Pings the API and receives a quote, then fills in all the boxes with the info */
        private async void GetQuoteButton_Click(object sender, EventArgs e)
        {
            Dashboard.Api = new TwelveDataClient(Dashboard.ApiKey, new HttpClient());

            var Quote = await Dashboard.Api.GetQuoteAsync(Symbol, "1day");

            _dateTimeBox.Text = Quote.Datetime.ToString();
            _priceBox.Text = Quote.Close.ToString("C2");
            _volumeTextBox.Text = Quote.Volume.ToString();
            _dailyHigh.Text = Quote.High.ToString("C2");
            _dailyLowTextBox.Text = Quote.Low.ToString("C2");
            _dailyChangeTextBox.Text = Quote.PercentChange.ToString("0.00") + '%';
        }

        // The radio button events change the whole stock list depending on the exchange
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

        /* Stores the symbol value of a selected stock for a quote */
        private void StockListBox_MouseClick(object sender, MouseEventArgs e)
        {
            Symbol = _stocks.Data[_stockListBox.SelectedIndex].Symbol;
            //MessageBox.Show(Symbol);
        } 

        /* Opens a buy form and fills in the pertinant info  */
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
            Close();
        }

        private void QuoteForm_Closing(object sender, FormClosingEventArgs e)
        {
            _mainForm.QuoteWin = null;
            _mainForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
