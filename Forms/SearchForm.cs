using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockForms
{
    public partial class SearchForm : Form
    {
        Dashboard _mainForm = null;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Form mainForm) {

            _mainForm = mainForm as Dashboard;

            InitializeComponent();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.SearchWin = null;
            _mainForm.Show();
        }
    }
}
