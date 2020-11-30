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

namespace BinaryExample
{
    public partial class Form1 : Form
    {
        FileStream filStream;
        BinaryWriter binWriter;
        BinaryReader binReader;
        string fileName = "binary.dat";
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileName)) {
                this.label1.Text = "File already exists!";
            }
            else
            {
                filStream = new FileStream(fileName, FileMode.CreateNew);
                binWriter = new BinaryWriter(filStream);
                decimal aValue = 2.16M;
                binWriter.Write("Sample Run");
                for (int i = 0; i < 11; i++)
                {
                    binWriter.Write(i);

                }
                binWriter.Write(aValue);
                binWriter.Close();
                filStream.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filStream = new FileStream(fileName, FileMode.Open,
                FileAccess.Read);
            binReader = new BinaryReader(filStream);

            this.listBox1.Items.Add(binReader.ReadString());
            for (int i = 0; i < 11; i++)
            {
                this.listBox1.Items.Add(binReader.ReadInt32());
            }

            this.listBox1.Items.Add(binReader.ReadDecimal());

            binReader.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
