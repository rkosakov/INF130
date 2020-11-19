using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppFromConsoleApp
{
    class Program : Form
    {
        public Program()
        {
            Text = "AUBG";
        }

        static void Main(string[] args)
        {
            Program winForm = new Program();
            Application.Run(winForm);
        }
    }
            

    
}

