using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerGUI
{
    public partial class OrderGUI : Form
    {
        private Order newOrder;
        public OrderGUI()
        {
            InitializeComponent();
        }

        private void OrderGUI_Load(object sender, EventArgs e)
        {
            newOrder = new Order();

            for (int i = 0; i < newOrder.menuEntree.Length; i++)
            {
                this.lstBxEntree.Items.Add(newOrder.menuEntree[i]);
            }
        }

        private void lstBxEntree_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.Entree = this.lstBxEntree.Text;
        }

        private void cmbxSpecial_SelectedIndexChanged(object sender, EventArgs e)
        {
            newOrder.SpecialRequest = this.lstBxEntree.Text;
        }

        private void cmbxSpecial_KeyPress(object sender, KeyPressEventArgs e)
        {
            newOrder.SpecialRequest = this.lstBxEntree.Text;
        }

        private void chBxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chBxWater.Checked)
            {
                newOrder.WaterSelection = true;
            }
            else
            {
                newOrder.WaterSelection = false;
            }
        }

        private void menuPlaceOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newOrder.Entree + "\n" +
                newOrder.SpecialRequest + "\n" +
                newOrder.DrinkSelection + "\n" +
                newOrder.GetWaterSelection() + "\n\n\n" +
                "Total amount: $" + newOrder.DrinkPrice + newOrder.EntreePrice, "Placed Order" );
        }

        private void menuClearOrder_Click(object sender, EventArgs e)
        {
            this.lstBxEntree.ClearSelected();
            this.chBxWater.Checked = false;
            this.cmbxSpecial.SelectedIndex = -1;
            this.cmbxSpecial.Text = String.Empty;
            this.ClearDrinks();
            newOrder.DrinkSelection = String.Empty;
            newOrder.Entree = String.Empty;
            newOrder.SpecialRequest = String.Empty;
            newOrder.WaterSelection = false;
        }

        public void ClearDrinks()
        {
            this.radMilk.Checked = false;
            this.radJuice.Checked = false;
            this.radSoda.Checked = false;
            this.radLemonade.Checked = false;
            this.radTea.Checked = false;
            this.radCoffee.Checked = false;
        }
    }
}
