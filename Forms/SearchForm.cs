using StockForms.Extra_API;
using StockForms.ResultModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockForms
{
    public partial class SearchForm : Form
    {
        StockListModel _results;
        List<Stock> _nameSearch;

        Dashboard _mainForm = null;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;

            InitializeComponent();
            FillStockList();
        }

        private async void FillStockList()
        {
            _results = await ApiProcessor.LoadStockList();

            _resultsListBox.DataSource = _results.Data;
            _resultsListBox.DisplayMember = "FullInfo";
        }

        private async void FillStockList(
            bool SignatureActivation,
            string Ticker = "",
            string Name = "",
            string Exchange = "",
            string Mic = "",
            string Type = ""
        ) {
        
            if (!Name.Equals("")) {

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

                    _results = await ApiProcessor.LoadStockList(true, default, "NASDAQ", default, default);

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
                */
            }

            else {

                _results = await ApiProcessor.LoadStockList(true, Ticker, Exchange, Mic, Type);

                _resultsListBox.DataSource = _results.Data;
                _resultsListBox.DisplayMember = "FullInfo";
            }


        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            /*
            if (_tickerTextBox.Text.Equals(""))
                MessageBox.Show("EQUAL");
            else MessageBox.Show("NOT EQUAL");
            */

            FillStockList(true,
                _tickerTextBox.Text,
                _exchangeComboBox.Text,
                _micTextBox.Text,
                _typeComboBox.Text
            );

            /*
            if (_tickerTextBox.Text == null) MessageBox.Show("NULL");
            else if (_tickerTextBox.Text == "") MessageBox.Show("BLANK STRING");
            else if (_tickerTextBox.Text == " ") MessageBox.Show("SPACED S");
            */
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

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.SearchWin = null;
            _mainForm.Show();
        }
    }
}
