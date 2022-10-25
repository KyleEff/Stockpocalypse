using StockForms.DBWires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;

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
            StreamWriter fileWriter;

            try {

                fileWriter = new StreamWriter("Cash.txt", true);
                fileWriter.Write(cash);
                fileWriter.Close();
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
