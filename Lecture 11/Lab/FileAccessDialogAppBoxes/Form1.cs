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

namespace FileAccessDialogAppBoxes
{
    public partial class Form1 : Form
    {
        StreamReader inFile;
        StreamWriter outFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();

                inFile = new StreamReader(openFileDialog1.FileName);

                lblMessage.Text = "File " + openFileDialog1.FileName;
                inFile.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                string testValue = "This is an example using Dialog boxes";
                outFile = new StreamWriter(saveFileDialog1.FileName);
                outFile.WriteLine(testValue);
                outFile.Close();

            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
