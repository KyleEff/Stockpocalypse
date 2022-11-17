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
    /*
     * This is the MAIN FORM
     * Everything the program does extends from this panel / class
     * 
     * The API Key is a unique key that is used to track the use of traffic credits
     * The Client is used to access the HTTP port
     * The API is for the TwelveData Finance API.
     *  This is not made by TwelveData; It is a third-party extension
     *  
     *  Cash is for the display of the user's cash deposits
     *  CashBox is used to access and alter the Cash Text property from other windows
     *  
     *  The Window Properties are used to check for and open other option windows from the main form
     */

    public partial class Dashboard : Form, ICashManagement
    {
        // API Properties
        public static string ApiKey { get { return "337b8d2e149a46b48bce81b03371004e"; } }
        public static HttpClient Client { get; set; }
        public static TwelveDataClient Api { get; set; }

        // Cash Properties
        public static double Cash { get; set; }
        public string CashBox { 
        
            get { return CashTextBox.Text; }
            set { CashTextBox.Text = value; }
        }

        // Window Properties
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

        /* This function sets the Cash display */
        public void SetCash()
        {
            //MessageBox.Show("SETCASH");
            try
            {   // This section reads the data from a file
                StreamReader FileReader = new StreamReader("C:\\Users\\Public\\Documents\\Cash.txt");
                Cash = Convert.ToDouble(FileReader.ReadLine());
                FileReader.Close();
                CashTextBox.Text = Cash.ToString("C2");

                //MessageBox.Show(Cash.ToString("C2"));
            }
            catch (Exception e)
            {   // Print the exception message
                MessageBox.Show(e.Message + $"\n");

                // Attempt to create a file and deposit cash
                DepositCash();
            }
        }

        /* This function writes data to the cash.txt file */
        public void WriteCash()
        {
            //MessageBox.Show("WRITECASH");
            //StreamWriter fileWriter;

            try
            {
                /*
                fileWriter = new StreamWriter("C:\\Users\\Public\\Documents\\Cash.txt", true);
                fileWriter.Write(Cash);
                fileWriter.Close();
                */

                /* The following function is supposed to create and write to a new file if one
                 * does not exist. This has not been happening and could require the
                 * user to create a text file at the Public Documents directory.
                 */
                File.WriteAllText("C:\\Users\\Public\\Documents\\Cash.txt", Cash.ToString());
                 
                //MessageBox.Show(Cash.ToString("C2"));

                SetCash();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Open Window Functions

        /*
         * The following functions check for the existence of certain windows
         * and opens one if it does not exist, passing the mainform into the constructor
         */
        public void DepositCash() {

            if (_depositWin == null)
            {
                _depositWin = new DepositBox(this);
                _depositWin.Show();
            }
        }

        public void OpenSearchWindow() {

            if (SearchWin == null)
            {
                SearchWin = new SearchForm(this);
                SearchWin.Show();
                Hide();
            }
        }

        public void OpenQuoteWindow()
        {
            if (QuoteWin == null)
            {
                QuoteWin = new QuoteForm(this);
                QuoteWin.Show();
            }
        }

        public void OpenBuyWindow() {

            if (BuyStockWin == null)
            {
                BuyStockWin = new BuyStockForm(this);
                BuyStockWin.Show();
            }
        }

        public void OpenSellWindow() {

            if (SellStockWin == null)
            {
                SellStockWin = new SellStockForm(this);
                SellStockWin.Show();
            }
        }

        public void OpenPortfolioWindow() { 
        
            if (PorfolioWin == null) {

                PorfolioWin = new PortfolioForm(this);
                PorfolioWin.Show();
            }
        }

        /*
         * This function sets the market indicies on the mainform,
         * giving the user an outlook on the market for the day
         */
        private async void SetIndices() {

            // Start up a new API
            Api = new TwelveDataClient(ApiKey, new HttpClient());

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

            // If the indicies are up over 0.9%, the Market will be considered "UP"
            if (
                (double.Parse(_djiChangeTextBox.Text) > 0.9)
                ||
                (double.Parse(_spChangeTextBox.Text) > 0.9)
            ) { MarketDaily.Append("UP"); }

            // If the indicies are down over 0.9%, the Market will be considered "DOWN"
            else if (
                (double.Parse(_djiChangeTextBox.Text) < -0.9)
                ||
                (double.Parse(_spChangeTextBox.Text) < -0.9)
            ) { MarketDaily.Append("DOWN"); }

            // Otherwise, the market will be considered "SIDEWAYS"
            else { MarketDaily.Append("SIDEWAYS"); }
            
            // Set Text
            _marketTodayLabel.Text = MarketDaily.ToString();
            
        }

        // EVENTS
        private void DepositCashButton_Click(object sender, EventArgs e)
        {
            DepositCash();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OpenSearchWindow();
        }

        private void GetQuoteButton_Clicked(object sender, EventArgs e)
        {
            OpenQuoteWindow();
        }

        private void BuyButtonClick(object sender, EventArgs e)
        {
            OpenBuyWindow();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            OpenSellWindow();
        }

        private void ViewPortfolioButton_Click(object sender, EventArgs e)
        {
            OpenPortfolioWindow();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
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
            OpenSearchWindow();
        }

        private void QuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuoteWindow();
        }

        private void BuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBuyWindow();
        }

        private void SellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSellWindow();
        }

        private void PortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPortfolioWindow();
        }
    }
}
