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

namespace PE5
{
    public partial class Form1 : Form
    {
        StreamReader fileRead;
        StreamWriter fileWrite;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;

            double payRate = double.Parse(textBox4.Text);
            double hours = double.Parse(textBox5.Text);

            double totalPay;

            if (hours > 40)
            {
                totalPay = 40 * payRate + (hours - 40) * 1.5 * payRate;

            }
            else
            {
                totalPay = payRate * hours;
            }

            try
            {
                saveFileDialog1.ShowDialog();

                string data = $"{lastName}, {firstName}  {totalPay:c2}";
                fileWrite = new StreamWriter(saveFileDialog1.FileName);
                fileWrite.WriteLine(data);
                fileWrite.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            btnRetrieve.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            
            string inValue;
            try
            {
                openFileDialog1.ShowDialog();
                fileRead = new StreamReader(openFileDialog1.FileName);
                while ((inValue = fileRead.ReadLine()) != null)
                {
                    this.txtBxInput.Text = inValue;

                }

                fileRead.Close();
                txtBxInput.Visible = true;
                btnStore.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        
    }
}
