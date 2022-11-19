using StockForms.Extra_API;
using StockForms.ResultModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockForms
{
    /*
     * This is the Search Form. This form is used to search for stocks using
     *  information that is input from the user.
     *  
     *  _results is used to encapsulate the results from an API ping
     *  _search is used to compile the stocks from NYSE and NASDAQ exchanges
     *      so they can be searched using in-class functions.
     *  _names is used to add names that match a name search to a list that will be displayed
     *  
     *  _mainForm is used to store a reference to the Dashboard
     */

    public partial class SearchForm : Form
    {
        StockListModel _results;
        List<Stock> _search = new List<Stock>();
        List<Stock> _names = new List<Stock>();

        Dashboard _mainForm = null;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;

            InitializeComponent();
            FillStockList();

            // Warning Window - UNDER CONSTRUCTION
            MessageBox.Show("THIS WINDOW DOES NOT WORK PROPERLY AND IS UNDER A LOT OF CONSTRUCTION");
        }

        /* This function is used to fill the stock list with stocks from NYSE & NASDAQ */
        private async void FillStockList()
        {
            // This following section adds two exchanges to a single list (NYSE and NASDAQ)
            _results = await ApiProcessor.LoadStockList();
            
            foreach(var stock in _results.Data)
                _search.Add(stock);

            _results = await ApiProcessor.LoadStockList("NASDAQ");

            foreach (var stock in _results.Data)
                _search.Add(stock);

            // This function sorts the list by name
            _search.Sort(delegate(Stock x, Stock y){

                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });

            // Display to user
            _resultsListBox.DataSource = _search;
            _resultsListBox.DisplayMember = "FullInfo";
        }

        // OBSOLETE
        /*
        private async void FillStockList(
            bool SignatureActivation,
            string Ticker = "",
            string Name = "",
            string Exchange = "",
            string Mic = "",
            string Type = ""
        ) {
        
            if (!Name.Equals(String.Empty)) {

                MessageBox.Show("NAME SEARCH");

                _nameSearch = new List<Stock>();
            
                // TEST STATEMENT
                _results = await ApiProcessor.LoadStockList();

                foreach (var item in _results.Data) { 
                
                    if (item.Name == Name) {

                        _nameSearch.Add(item);
                    }
                }

                if (_nameSearch.Count < 1) {

                    // PROBLEMS
                    // NOT COMPLETE
                    // WORK ON IT
                    _results = await ApiProcessor.LoadStockList(new Stock() { Name = "" });

                    _results. await ApiProcessor.LoadStockList(true, default, "NASDAQ", default, default);

                    foreach (var item in _results.Data)
                    {
                        if (item.Name == Name)
                        {
                            _nameSearch.Add(item);
                        }
                    }
                }
                
                _resultsListBox.DataSource = _nameSearch;
                _resultsListBox.DisplayMember = "FullInfo";

                /*
                MessageBox.Show($"names length: { names.Count }");

                TestFORM test = new TestFORM();

                test.listBox1.DataSource = names;
                test.listBox1.DisplayMember = "FullInfo";

                test.Show();
                
                
            }

            else {

                _results = await ApiProcessor.LoadStockList(true, Ticker, Exchange, Mic, Type);

                _resultsListBox.DataSource = _results.Data;
                _resultsListBox.DisplayMember = "FullInfo";
            }


        }*/

        /* This function is used to fill the stock list using information form a Stock Object */
        private async void FillStockList(Stock searchStock)
        {
            if (!searchStock.Name.Equals(String.Empty))
            {   // The name search only works once, I don't know why this is.
                // MORE DEBUGGING REQUIRED
                MessageBox.Show("NAME SEARCH");

                // This loop runs through each stock in the _search list to match a name
                foreach (var stock in _search)
                    if (stock.Name.Equals(searchStock.Name))
                        _names.Add(stock);

                // Displays the list of matching names.
                if (_names.Count > 0)
                {
                    _resultsListBox.DataSource = _names;
                    _resultsListBox.DisplayMember = "FullInfo";
                }
                else MessageBox.Show("No name match");

                /*
                MessageBox.Show($"names length: { names.Count }");

                TestFORM test = new TestFORM();

                test.listBox1.DataSource = names;
                test.listBox1.DisplayMember = "FullInfo";

                test.Show();
                */
            }

            else
            {   // Searches using other criteria
                _results = await ApiProcessor.LoadStockList(searchStock);

                _resultsListBox.DataSource = _results.Data;
                _resultsListBox.DisplayMember = "FullInfo";
            }
        }

        // EVENTS
        private void SearchButton_Click(object sender, EventArgs e) =>
        
            FillStockList(new Stock()
            {
                Symbol = _tickerTextBox.Text,
                Name = _nameTextBox.Text,
                Exchange = _exchangeComboBox.Text,
                Mic_code = _micTextBox.Text,
                Type = _typeComboBox.Text
            }) ;
        
        private void ExitButton_Click(object sender, EventArgs e) => Close();

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) =>
        
            MessageBox.Show(
                "This software is being developed by:\n" +
                "KFree, LLC\n" +
                "2022"
            );
        
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        
        private void SearchToolStripMenuItem_Click(object sender, EventArgs e) => _mainForm.OpenSearchWindow();
        
        private void QuoteToolStripMenuItem_Click(object sender, EventArgs e) => _mainForm.OpenQuoteWindow();
        
        private void BuyToolStripMenuItem_Click(object sender, EventArgs e) => _mainForm.OpenBuyWindow();
        
        private void SellToolStripMenuItem_Click(object sender, EventArgs e) => _mainForm.OpenSellWindow();
       
        private void PortfolioToolStripMenuItem_Click(object sender, EventArgs e) => _mainForm.OpenPortfolioWindow();
        
        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.SearchWin = null;
            _mainForm.Show();
        }
    }
}
