using StockForms.DBWires;
using System;
using System.Windows.Forms;

namespace StockForms.Forms
{
    /*
     * This form is for the user to view their portfolio. 
     */
    public partial class PortfolioForm : Form
    {
        DataGridViewCellCollection _row = null;

        Dashboard _mainForm = null;

        public PortfolioForm()
        {
            InitializeComponent();
        }

        public PortfolioForm(Form MainForm) {

            _mainForm = MainForm as Dashboard;

            InitializeComponent();
            _mainForm.Hide();
            SetPurchaseValue();
        }

        void SetPurchaseValue() {

            double total = 0.0;
            
            for (var each = 0; each < this._portfolioDataGridView.Rows.Count; each++) {

                total += Convert.ToDouble(this._portfolioDataGridView.Rows[each].Cells[5].Value);

                MessageBox.Show(this._portfolioDataGridView.Rows[each].Cells[5].Value.ToString());
            }

            //MessageBox.Show(total.ToString("C2"));
        }

        // OBSOLETE
        /*
        private void FillPortfolio() {

            DataAccess database = new DataAccess();

            _portfolioDataGridView.DataSource = database.ViewPortfolio();
        }*/

        // EVENTS
        void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This software is being developed by:\n" +
                "KFree, LLC\n" +
                "2022"
            );
        }

        void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
        
        void SearchToolStripMenuItem_Click(object sender, EventArgs e) => _mainForm.OpenSearchWindow();
        
        void QuoteToolStripMenuItem_Click(object sender, EventArgs e) => _mainForm.OpenQuoteWindow();
        
        void BuyToolStripMenuItem_Click(object sender, EventArgs e) => _mainForm.OpenBuyWindow();

        void SellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenSellWindow();
        }

        void PortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenPortfolioWindow();
        }

        void PortfolioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.PorfolioWin = null;
            _mainForm.Show();
        }

        void PortfolioForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viewPortfolio.portfolio' table. You can move, or remove it, as needed.
            this.portfolioTableAdapter.Fill(this.viewPortfolio.portfolio);
        }

        void PortfolioDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try { _row = this._portfolioDataGridView.Rows[e.RowIndex].Cells; }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        async void BuyButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenBuyWindow();
            _mainForm.BuyStockWin.SymbolTextBox.Text = _row["stock_ticker"].Value.ToString();
            _mainForm.BuyStockWin.NameTextBox.Text = _row["stock_name"].Value.ToString();

            _mainForm.BuyStockWin.PriceTextBox.Text = await SellStockForm.GetPrice(
                _mainForm.BuyStockWin.SymbolTextBox.Text
            );
        }

        void SellButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenSellWindow();
        }

        void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
