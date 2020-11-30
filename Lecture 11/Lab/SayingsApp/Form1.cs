using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SayingsApp
{
    public partial class Form1 : Form
    {
        
            private StreamWriter fill;

           
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fill = new StreamWriter("saying.txt");

            }
            catch (DirectoryNotFoundException exc)
            {

                lblMessage.Text = "Ivalid Directory:\n" + exc.Message;
            }
            catch(System.IO.IOException exc)
            {
                lblMessage.Text = exc.Message;
            }

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            try
            {
                fill.WriteLine(txtBxInput.Text);
                txtBxInput.Text = "";
                txtBxInput.Focus();
            }
            catch (IOException exc)
            {

                lblMessage.Text = exc.Message;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fill.Close();
            }
            catch (Exception)
            {

                lblMessage.Text = "File did not close properly";
            }
        }
    }
}
