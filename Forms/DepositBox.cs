using StockForms.DBWires;
using System;
using System.Windows.Forms;

namespace StockForms.Forms
{
    public partial class DepositBox : Form
    {
        Dashboard _mainForm = null;

        public DepositBox()
        {
            InitializeComponent();
        }

        public DepositBox(Form mainForm) {

            _mainForm = mainForm as Dashboard;
            InitializeComponent();
        }

        public void DepositCash(double cash)
        {
            try {

                if (Dashboard.Cash >= 0) {

                    Dashboard.Cash += cash;
                    _mainForm.WriteCash();
                }
                _mainForm.SetCash();

            } catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            DepositCash(double.Parse(DepositTextBox.Text));
            Close();
        }
    }
}
