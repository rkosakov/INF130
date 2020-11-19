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

namespace Example2
{
    public partial class Form1 : Form
    {
        private StreamWriter file;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                file = new StreamWriter("saying.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                lblMessage.Text = "Invalid Directory: \n" + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                lblMessage.Text = exc.Message;
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            try
            {
                file.WriteLine(textBox1.Text);
                textBox1.Text = String.Empty;
                textBox1.Focus();
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
                file.Close();
            }
            catch (IOException exc)
            {

                lblMessage.Text = "File not closed properly!";
            }
        }
    }
}
