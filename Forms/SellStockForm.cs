﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockForms.ResultModels;
using StockForms.Extra_API;
using System.Windows.Forms;

namespace StockForms.Forms
{
    public partial class SellStockForm : Form
    {
        private Form _mainForm = null;

        public SellStockForm()
        {
            InitializeComponent();
        }

        public SellStockForm(Form mainForm) {

            InitializeComponent();
            _mainForm = mainForm as Dashboard;
        }
    }
}
