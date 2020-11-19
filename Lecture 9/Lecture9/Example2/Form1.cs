using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2
{
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void lstBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBoxResult.Text = lstBoxEvents.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lstBoxEvents.Items.Add(textBox1.Text);
        }
    }
}
