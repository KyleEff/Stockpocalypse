using Dapper;
using Stock_Program;
using StockForms.DBWires;
using StockForms.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwelveDataSharp;
using StockForms.Interfaces;
using System.Runtime.CompilerServices;

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

        public SearchForm SearchWin { get; set; }
        private QuoteForm _quoteWin { get; set; }
        private DepositBox _depositWin { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            SetCash();
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
            if (_quoteWin == null) {

                _quoteWin = new QuoteForm(this);
                _quoteWin.Show();
            }
        }

        private void DepositCashButton_Click(object sender, EventArgs e)
        {
            DepositCash();
        }

        private async void TimeSeriesTestButton_Click(object sender, EventArgs e)
        {
            Client = new HttpClient();
            Api = new TwelveDataClient(ApiKey, Client);

            var TimeSeries = await Api.GetTimeSeriesAsync("SPY", "1week");

            MessageBox.Show(

                TimeSeries.Interval + '\n' +
                TimeSeries.Exchange + '\n' +
                TimeSeries.Values[0].Close
            );
        }
    }
}
