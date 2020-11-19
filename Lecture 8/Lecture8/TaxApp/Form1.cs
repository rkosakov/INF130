using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string inValue;
            double purchaseAmt, percent, ans;

            inValue = txtPurchase.Text;
            while (double.TryParse(txtPurchase.Text, out purchaseAmt) == false)
            {
                MessageBox.Show("Wrong Input! Try Again!");
                txtPurchase.Text = "0.0";
                txtPurchase.Focus();

            }

            inValue = label5.Text;

            inValue = inValue.Remove(inValue.Length - 1, 1);

            percent = double.Parse(inValue) / 100;

            ans = (purchaseAmt * percent) + purchaseAmt;

            txtTotalDue.Text = String.Format("{0:C}", ans).ToString();
        }
    }
}
