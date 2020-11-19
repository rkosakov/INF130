using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE4
{
    public partial class guessingGameAppForm : Form
    {
        private Random randValue = new Random();

        int attempts = 0;
        int target;


        public guessingGameAppForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            randValue = new Random();
            target = randValue.Next(0, 101);
        }


        private void btnGuess_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtBxNumber.Text);


            if (number == target)
            {
                lblDirections.Text = $"You got it... You Won!";
                target = randValue.Next(0, 101);
                attempts++;
                lblCount.Text = attempts.ToString();
                BackColor = Color.Fuchsia;



            }
            else if (number > target)
            {
                lblDirections.Text = $"{number} is too high";
                attempts++;
                lblCount.Text = attempts.ToString();
                BackColor = Color.Red;

            }
            else if (number < target)
            {
                lblDirections.Text = $"{number } is too low";
                attempts++;
                lblCount.Text = attempts.ToString();
                BackColor = Color.Green;
            }




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            attempts = 0;
            lblCount.Text = "";
            BackColor = Color.Fuchsia;
            lblDirections.Text = "";
            randValue = new Random();
            target = randValue.Next(0, 101);
        }

        private void guessingGameAppForm_ForeColorChanged(object sender, EventArgs e)
        {

        }
    }
}
