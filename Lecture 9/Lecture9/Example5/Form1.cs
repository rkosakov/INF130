using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example5
{
    public partial class PizzaForm : Form
    {
        private string order;
        private double totalCost;
        public PizzaForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {
            this.cmboSize.SelectedIndex = 1;
            this.cmboCrust.SelectedIndex = 0;
            this.cmboSpec.SelectedIndex = 0;
            this.txtBxSodaQuant.Text = "0";
            this.txtBxWaterQuant.Text = "0";
            order = String.Empty;
            totalCost = 0;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double drinkCost,
                   pizzaCost,
                   specCost;

                    
        }
    }
}
