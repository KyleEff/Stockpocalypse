using StockForms.DBWires;
using StockForms.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwelveDataSharp;

namespace StockForms.Forms
{
    /*
     * This from runs all selling transactions,
     *  interacting with both the API and the 
     */

    public partial class SellStockForm : Form, ITransaction
    {
        double _profit { get; set; }
        double _total { get; set; }

        Dashboard _mainForm = null;
        DataGridViewCellCollection _row;

        Order _selected; // This is used to store information from the selected row as well

        // Constructors
        public SellStockForm()
        {
            InitializeComponent();
        }

        public SellStockForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;

            InitializeComponent();
            CashTextBox.Text = _mainForm.CashBox;
            _mainForm.Hide();
        }

        /* This function sets the total of the order (price * quantity) */
        public void SetTotal() {

            string PriceString = "";
            // Check the pricebox for a dollar sign and then assign the price
            if (PriceTextBox.Text != null)
            {
                if (PriceTextBox.Text[0] == '$')
                    for (var letter = 1; letter < PriceTextBox.Text.Length; letter++)
                        PriceString += PriceTextBox.Text[letter];
                else PriceString = PriceTextBox.Text;
            }

            //MessageBox.Show(PriceString);
            // If the quantity box is not empty
            if (!QuantityTextBox.Text.Equals("0") && !QuantityTextBox.Text.Equals(""))
            {
                // Does the math to calculate the total
                TotalTextBox.Text = (Convert.ToDouble(PriceString) * Convert.ToDouble(QuantityTextBox.Text)).ToString("C2");

                // This loop removes the dollar sign and stores the total
                PriceString = "";
                for (var letter = 1; letter < TotalTextBox.Text.Length; letter++)
                    PriceString += TotalTextBox.Text[letter];

                _total = Convert.ToDouble(PriceString);

                // Calculate profit (total - (dca * order quantity))
                _profit =
                    _total
                    -
                    (Convert.ToDouble(_row[4].Value) * Convert.ToInt32(QuantityTextBox.Text));

                // Display profit
                _profitTextBox.Text = _profit.ToString("C2");
            }
            // Display zero if there is no quantity
            else TotalTextBox.Text = "$0.00";
        }

        /* 
         * This function runs the transaction, using the data to create an order
         *  that is sent to the database, and then the user's portfolio is changed
         *  depending on the contents of the order.
         */
        public void Transact() {
            // SELL SELL SELL
            // Create a database object and fill in an order object with the order information
            var Database = new DataAccess();
            string PriceString = "";

            // Check for dollar sign and remove it
            if (PriceTextBox.Text != null)
            {
                if (PriceTextBox.Text[0] == '$')
                    for (var letter = 1; letter < PriceTextBox.Text.Length; letter++)
                        PriceString += PriceTextBox.Text[letter];
                else PriceString = PriceTextBox.Text;
            }

            Order order = new Order() {

                Buy = false,
                Stock_Ticker = "'" + SymbolTextBox.Text + "'",
                Stock_Name = "'" + NameTextBox.Text + "'",
                Price = Convert.ToDouble(PriceString),
                Quantity = Convert.ToInt32(QuantityTextBox.Text)
            };

            //MessageBox.Show(order.FullInfo);

            // Check if the quantity of the order is less than or equal to the amount owned
            if (order.Quantity <= _selected.Quantity)
            {
                /*
                Database.SendOrder(
                    false, // The buy boolean is false because this is a sell order
                    SymbolTextBox.Text,
                    NameTextBox.Text,
                    _price,
                    Convert.ToInt32(QuantityTextBox.Text)
                );*/
                // Send order to database
                Database.SendOrder(order);

                // Change portfolio
                Database.AlterPortfolio(order);

                // Add cash and write to file
                Dashboard.Cash += order.Total;
                _mainForm.WriteCash();

                // Show Order results
                OrderResultsTextBox.Text = Database.ViewMostRecentOrder()[0].FullInfo;
            }
            else {
                // If there are not enough securities, kick a message and fail the order.
                MessageBox.Show("You do not own enough securites for this transaction!!!");

                OrderResultsTextBox.Text = "ORDER FAILED";
            }

            // Set the cash display
            CashTextBox.Text = _mainForm.CashBox;
        }

        /* Pings the API to get a price */
        public static async Task<string> GetPrice(string Ticker)
        {
            //MessageBox.Show("TICKER: " + Ticker);
            if (!Ticker.Equals(String.Empty))
            {
                Dashboard.Api = new TwelveDataClient(
                    Dashboard.ApiKey,
                    new HttpClient()
                );
                
                var price = await Dashboard.Api.GetRealTimePriceAsync(Ticker);
                return price.Price.ToString("C2");
            }
            else return "0.00";
        }
        
        // OBSOLETE
        /*
        private void FillPortfolioList() { 

            var database = new DataAccess();

            _portfolio = database.ViewPortfolio();

            _portfolioDataGridView.DataSource = _portfolio;
        }
        */

        // EVENTS
        void SellButton_Click(object sender, EventArgs e) => Transact();

        void QuantityTextBox_TextChanged(object sender, EventArgs e) => SetTotal();
        
        async void PriceButton_Click(object sender, EventArgs e) => PriceTextBox.Text = await GetPrice(SymbolTextBox.Text);
        
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

        void BuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenBuyWindow();
        }

        void SellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenSellWindow();
        }

        void PortfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainForm.OpenPortfolioWindow();
        }

        void SellStockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.SellStockWin = null;
            _mainForm.Show();
        }

        void SellStockForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viewPortfolio.portfolio' table. You can move, or remove it, as needed.
            this.portfolioTableAdapter.Fill(this.viewPortfolio.portfolio);
        }

        /* This event is for selecting rows from the grid and storing the data */
        void PortfolioDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*
                var selectedRow = _portfolioDataGridView.SelectedRows[0].DataBoundItem as Customer_Portfolio;

                SymbolTextBox.Text = selectedRow.Stock_Ticker;
                NameTextBox.Text = selectedRow.Stock_Name;
                */

                _row = this._portfolioDataGridView.Rows[e.RowIndex].Cells;

                SymbolTextBox.Text = _row[1].Value.ToString();
                NameTextBox.Text = _row[2].Value.ToString();

                _selected = new Order() {

                    Stock_Ticker = _row[1].Value.ToString(),
                    Stock_Name = _row[2].Value.ToString(),
                    Quantity = Convert.ToInt32(_row[3].Value)
                };

                //MessageBox.Show(_selected.FullInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void PriceLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All currency is in United States Dollars.");
        }
    }
}
