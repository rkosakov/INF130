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

namespace Example3
{
    public partial class Form1 : Form
    {
        private StreamReader inFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string inValue;

            if (File.Exists("name.txt")) 
            {
                try
                {
                    inFile = new StreamReader("name.txt");

                    while ((inValue = inFile.ReadLine()) != null)
                    {
                        this.textBox1.Text += inValue + "\n";
                    }
                }
                catch (System.IO.IOException exc)
                {

                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("The file is not available");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                inFile.Close();
            }
            catch 
            {

                
            }
        }
    }
}
