﻿using StockForms.DBWires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockForms.Forms
{
    public partial class PortfolioForm : Form
    {
        Dashboard _mainForm = null;

        public PortfolioForm()
        {
            InitializeComponent();
        }

        public PortfolioForm(Form MainForm) {

            _mainForm = MainForm as Dashboard;

            InitializeComponent();
            //FillPortfolio();
            _mainForm.Hide();

        }

        private void FillPortfolio() {

            DataAccess database = new DataAccess();

            _portfolioDataGridView.DataSource = database.ViewPortfolio();
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

        private void PortfolioForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.PorfolioWin = null;
            _mainForm.Show();
        }

        private void PortfolioForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viewPortfolio.portfolio' table. You can move, or remove it, as needed.
            this.portfolioTableAdapter.Fill(this.viewPortfolio.portfolio);

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenBuyWindow();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            _mainForm.OpenSellWindow();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
