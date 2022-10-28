using Dapper;
using StockForms.DBWires;
using StockForms.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using TwelveDataSharp;
using StockForms.Interfaces;

namespace StockForms
{
    public partial class Dashboard : Form, ICashManagement
    {
        public static string ApiKey { get { return "337b8d2e149a46b48bce81b03371004e"; } }
        public static HttpClient Client { get; set; }
        public static TwelveDataClient Api { get; set; }
        public static double Cash { get; set; }
        public string CashBox { 
        
            get { return CashTextBox.Text; }
            set { CashTextBox.Text = value; }
        }

        private DepositBox _depositWin { get; set; }
        public SearchForm SearchWin { get; set; }
        public QuoteForm QuoteWin { get; set; }
        public BuyStockForm BuyStockWin { get; set; }
        public SellStockForm SellStockWin { get; set; }
        public PortfolioForm PorfolioWin { get; set; }


        public Dashboard()
        {
            InitializeComponent();
            SetCash();
            SetIndices();
        }

        // Interface Functions
        public void SetCash()
        {
            try
            {
                StreamReader FileReader = new StreamReader("Cash.txt");
                Cash = Convert.ToDouble(FileReader.ReadLine());
                FileReader.Close();
                CashTextBox.Text = Cash.ToString("C2");
                //MessageBox.Show(Cash.ToString("C2"));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                DepositCash();
            }
        }

        public void WriteCash()
        {
            //StreamWriter fileWriter;

            try
            {
                /*
                fileWriter = new StreamWriter("Cash.txt", true);
                fileWriter.WriteAll(Cash);
                fileWriter.Close();
                */

                File.WriteAllText("Cash.txt", Cash.ToString());

                MessageBox.Show(Cash.ToString("C2"));
                SetCash();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void DepositCash() {

            if (_depositWin == null)
            {
                _depositWin = new DepositBox(this);
                _depositWin.Show();
            }
        }

        private async void SetIndices() {

            Client = new HttpClient();
            Api = new TwelveDataClient(ApiKey, Client);

            // index initialization
            var dji = await Api.GetQuoteAsync("DJI", "1day");
            var sp = await Api.GetQuoteAsync("SPX", "1day");

            // Set up the DOW Jones Index 30
            _djiTextBox.Text = dji.Close.ToString("0.00");
            _djiHighTextBox.Text = dji.High.ToString("0.00");
            _djiLowTextBox.Text = dji.Low.ToString("0.00");
            _djiPrevTextBox.Text = dji.PreviousClose.ToString("0.00");
            _djiChangeTextBox.Text = dji.PercentChange.ToString("0.00");
            
            // Set up the S&P500 index
            _spTextBox.Text = sp.Close.ToString("0.00");
            _spHighTextBox.Text = sp.High.ToString("0.00");
            _spLowTextBox.Text = sp.Low.ToString("0.00");
            _spPrevTextBox.Text = sp.PreviousClose.ToString("0.00");
            _spChangeTextBox.Text = sp.PercentChange.ToString("0.00");

            _spChangeTextBox.ForeColor = Color.Lime;

            // Set Daily Market Outlook
            var MarketDaily = new StringBuilder(_marketTodayLabel.Text.ToString());

            if (
                (double.Parse(_djiChangeTextBox.Text) > 0.9)
                ||
                (double.Parse(_spChangeTextBox.Text) > 0.9)
            ) { MarketDaily.Append("UP"); }

            else if (
                (double.Parse(_djiChangeTextBox.Text) < -0.9)
                ||
                (double.Parse(_spChangeTextBox.Text) < -0.9)
            ) { MarketDaily.Append("DOWN"); }

            else { MarketDaily.Append("SIDEWAYS"); }
            
            _marketTodayLabel.Text = MarketDaily.ToString();
            
        }

        private void DepositCashButton_Click(object sender, EventArgs e)
        {
            DepositCash();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchWin == null) {

                SearchWin = new SearchForm(this);
                SearchWin.Show();
                Hide();
            }
        }

        private void GetQuoteButton_Clicked(object sender, EventArgs e)
        {
            if (QuoteWin == null) {

                QuoteWin = new QuoteForm(this);
                QuoteWin.Show();
            }
        }

        private void BuyButtonClick(object sender, EventArgs e)
        {
            if (BuyStockWin == null) {

                BuyStockWin = new BuyStockForm(this);
                BuyStockWin.Show();
            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            if (SellStockWin == null) {

                SellStockWin = new SellStockForm(this);
                SellStockWin.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
