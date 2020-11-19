using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_1
{
    public partial class Form1 : Form
    {
        delegate string ReturnsSimpleStrings();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = 18;
            ReturnsSimpleStrings saying1 = new ReturnsSimpleStrings(AHeading);
            ReturnsSimpleStrings saying2 = new ReturnsSimpleStrings((age + 10).ToString);
            ReturnsSimpleStrings saying3 = new ReturnsSimpleStrings(EndStatement);

            MessageBox.Show(saying1() + saying2() + saying3());

        }

        public string AHeading()
        {
            return "Your age will be ";
        }

        public string EndStatement()
        {
            return " in 10 years.";
        }
    }
}
