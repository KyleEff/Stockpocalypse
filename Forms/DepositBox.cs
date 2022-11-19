using System;
using System.Windows.Forms;

namespace StockForms.Forms
{
    /*
     * This is the deposit form. This takes a deposit value from the user
     *  and adds it to the cash reserves of the user.
     *  
     * _mainForm stores the Dashboard.
     */
    public partial class DepositBox : Form
    {
        Dashboard _mainForm = null;

        // Constructors
        public DepositBox()
        {
            InitializeComponent();
        }

        public DepositBox(Form mainForm) {

            _mainForm = mainForm as Dashboard;
            InitializeComponent();
        }

        /* This function takes a double value and adds it to the user's cash */
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

        // EVENTS
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
