using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            decimal cost = 0;
            this.lblInfo.Text = "  ";
            if (this.chBxSwim.Checked)
            {
                cost += 50;
            }
            if (this.chBxSnorkel.Checked)
            {
                cost += 25;
            }
            if (this.chBxDive.Checked)
            {
                cost += 100;
            }
            if (this.radBtnBeginner.Checked)
            {
                cost += 10;
                this.lblInfo.Text = "Beginner -- Extra $10 charge";
            }
            else
                if (this.radBtnAdvanced.Checked)
            {
                cost -= 15;
                this.lblInfo.Text = "Advanced -- Discount $15";
            }
            else
            {
                this.lblInfo.Text = "  ";
            }
            this.txtBxTotal.Text = cost.ToString("C");
        }
    }
}
