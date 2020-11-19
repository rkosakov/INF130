using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmboFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmboFlowers.SelectedIndexChanged += new System.EventHandler(this.cmboFlowers_SelectedIndexChanged);
           
        }
        private void cmboFlowers_TextChanged(object sender, System.EventArgs e)
        {
            this.txtBxResultFlowers.Text = cmboFlowers.Text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gardening Guide Application\n\n\nVersion" + " 1.0", "About Gardening");

        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = lblOutput.Font;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.Font = fontDialog1.Font;
            }
        }

        private void menuColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblOutput.ForeColor;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblOutput.ForeColor = colorDialog1.Color;
            }

        }
    }
}
