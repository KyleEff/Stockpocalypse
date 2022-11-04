namespace StockForms.Forms
{
    partial class PortfolioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._portfolioDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.portfoliosDataSet = new StockForms.portfoliosDataSet();
            this.portfoliosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPortfolio = new StockForms.ViewPortfolio();
            this.viewPortfolioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portfolioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.portfolioTableAdapter = new StockForms.ViewPortfolioTableAdapters.portfolioTableAdapter();
            this.customerPortfolioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerPortfolioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocktickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityownedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dollarcostaverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portfolioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfoliosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfoliosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPortfolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPortfolioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPortfolioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPortfolioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tradeToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(800, 24);
            this._menuStrip.TabIndex = 11;
            this._menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.quoteToolStripMenuItem,
            this.buyToolStripMenuItem,
            this.sellToolStripMenuItem,
            this.portfolioToolStripMenuItem});
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tradeToolStripMenuItem.Text = "Trade";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // quoteToolStripMenuItem
            // 
            this.quoteToolStripMenuItem.Name = "quoteToolStripMenuItem";
            this.quoteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.quoteToolStripMenuItem.Text = "Quote";
            this.quoteToolStripMenuItem.Click += new System.EventHandler(this.QuoteToolStripMenuItem_Click);
            // 
            // buyToolStripMenuItem
            // 
            this.buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            this.buyToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.buyToolStripMenuItem.Text = "Buy";
            this.buyToolStripMenuItem.Click += new System.EventHandler(this.BuyToolStripMenuItem_Click);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.SellToolStripMenuItem_Click);
            // 
            // portfolioToolStripMenuItem
            // 
            this.portfolioToolStripMenuItem.Name = "portfolioToolStripMenuItem";
            this.portfolioToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.portfolioToolStripMenuItem.Text = "Portfolio";
            this.portfolioToolStripMenuItem.Click += new System.EventHandler(this.PortfolioToolStripMenuItem_Click);
            // 
            // _portfolioDataGridView
            // 
            this._portfolioDataGridView.AllowUserToAddRows = false;
            this._portfolioDataGridView.AllowUserToDeleteRows = false;
            this._portfolioDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._portfolioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._portfolioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._portfolioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stocktickerDataGridViewTextBoxColumn,
            this.stocknameDataGridViewTextBoxColumn,
            this.quantityownedDataGridViewTextBoxColumn,
            this.dollarcostaverageDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this._portfolioDataGridView.DataSource = this.portfolioBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._portfolioDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._portfolioDataGridView.Location = new System.Drawing.Point(145, 27);
            this._portfolioDataGridView.Name = "_portfolioDataGridView";
            this._portfolioDataGridView.ReadOnly = true;
            this._portfolioDataGridView.Size = new System.Drawing.Size(643, 357);
            this._portfolioDataGridView.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 390);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 48);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(126, 356);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // portfoliosDataSet
            // 
            this.portfoliosDataSet.DataSetName = "portfoliosDataSet";
            this.portfoliosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // portfoliosDataSetBindingSource
            // 
            this.portfoliosDataSetBindingSource.DataSource = this.portfoliosDataSet;
            this.portfoliosDataSetBindingSource.Position = 0;
            // 
            // viewPortfolio
            // 
            this.viewPortfolio.DataSetName = "ViewPortfolio";
            this.viewPortfolio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPortfolioBindingSource
            // 
            this.viewPortfolioBindingSource.DataSource = this.viewPortfolio;
            this.viewPortfolioBindingSource.Position = 0;
            // 
            // portfolioBindingSource
            // 
            this.portfolioBindingSource.DataMember = "portfolio";
            this.portfolioBindingSource.DataSource = this.viewPortfolioBindingSource;
            // 
            // portfolioTableAdapter
            // 
            this.portfolioTableAdapter.ClearBeforeFill = true;
            // 
            // customerPortfolioBindingSource
            // 
            this.customerPortfolioBindingSource.DataSource = typeof(StockForms.DBWires.Customer_Portfolio);
            // 
            // customerPortfolioBindingSource1
            // 
            this.customerPortfolioBindingSource1.DataSource = typeof(StockForms.DBWires.Customer_Portfolio);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // stocktickerDataGridViewTextBoxColumn
            // 
            this.stocktickerDataGridViewTextBoxColumn.DataPropertyName = "stock_ticker";
            this.stocktickerDataGridViewTextBoxColumn.HeaderText = "Stock Symbol";
            this.stocktickerDataGridViewTextBoxColumn.Name = "stocktickerDataGridViewTextBoxColumn";
            this.stocktickerDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocktickerDataGridViewTextBoxColumn.ToolTipText = "This is the symbol that the market uses to represent the stock of the company.";
            this.stocktickerDataGridViewTextBoxColumn.Width = 75;
            // 
            // stocknameDataGridViewTextBoxColumn
            // 
            this.stocknameDataGridViewTextBoxColumn.DataPropertyName = "stock_name";
            this.stocknameDataGridViewTextBoxColumn.HeaderText = "Stock Name";
            this.stocknameDataGridViewTextBoxColumn.Name = "stocknameDataGridViewTextBoxColumn";
            this.stocknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocknameDataGridViewTextBoxColumn.ToolTipText = "This is the name of the company that the stock represents.";
            this.stocknameDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantityownedDataGridViewTextBoxColumn
            // 
            this.quantityownedDataGridViewTextBoxColumn.DataPropertyName = "quantity_owned";
            this.quantityownedDataGridViewTextBoxColumn.HeaderText = "Quantity Owned";
            this.quantityownedDataGridViewTextBoxColumn.Name = "quantityownedDataGridViewTextBoxColumn";
            this.quantityownedDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityownedDataGridViewTextBoxColumn.ToolTipText = "This is the amount of shares owned in the portfolio.";
            this.quantityownedDataGridViewTextBoxColumn.Width = 75;
            // 
            // dollarcostaverageDataGridViewTextBoxColumn
            // 
            this.dollarcostaverageDataGridViewTextBoxColumn.DataPropertyName = "dollar_cost_average";
            this.dollarcostaverageDataGridViewTextBoxColumn.HeaderText = "Dollar Cost Average";
            this.dollarcostaverageDataGridViewTextBoxColumn.Name = "dollarcostaverageDataGridViewTextBoxColumn";
            this.dollarcostaverageDataGridViewTextBoxColumn.ReadOnly = true;
            this.dollarcostaverageDataGridViewTextBoxColumn.ToolTipText = "This is the cost of each individual share regardless of the date they wrere bough" +
    "t. The simple formula is (Total Value / Quantity Owned)";
            this.dollarcostaverageDataGridViewTextBoxColumn.Width = 75;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.ToolTipText = "The total value of all the shares owned.";
            this.totalDataGridViewTextBoxColumn.Width = 75;
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._portfolioDataGridView);
            this.Controls.Add(this._menuStrip);
            this.Name = "PortfolioForm";
            this.Text = "View Portfolio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PortfolioForm_FormClosing);
            this.Load += new System.EventHandler(this.PortfolioForm_Load);
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._portfolioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfoliosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfoliosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPortfolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPortfolioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPortfolioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPortfolioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portfolioToolStripMenuItem;
        private System.Windows.Forms.DataGridView _portfolioDataGridView;
        private System.Windows.Forms.BindingSource customerPortfolioBindingSource;
        private System.Windows.Forms.BindingSource customerPortfolioBindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private portfoliosDataSet portfoliosDataSet;
        private System.Windows.Forms.BindingSource portfoliosDataSetBindingSource;
        private System.Windows.Forms.BindingSource viewPortfolioBindingSource;
        private ViewPortfolio viewPortfolio;
        private System.Windows.Forms.BindingSource portfolioBindingSource;
        private ViewPortfolioTableAdapters.portfolioTableAdapter portfolioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocktickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityownedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dollarcostaverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}