using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StaticMethod
{
    class StaticMethod
    {
        static void Main(string[] args)
        {
            double[] waterDepth = { 45, 19, 2, 16.8, 190, 0.8, 510, 6, 18 };
            double[] w = new double[20];

            DisplayOutput(waterDepth, "waterDepth Array \n\n");

            Array.Copy(waterDepth, 2, w, 0, 5);

            Array.Sort(w);
            DisplayOutput(w, "Array w Sorted\n\n");

            Array.Reverse(w);
            DisplayOutput(w, "Array w Reversed \n\n");
        }

        public static void DisplayOutput(double[] anArray, string msg)
        {
            foreach (double wVal in anArray)
            {
                if (wVal > 0)
                {
                    msg += wVal + "\n";
                }
                MessageBox.Show(msg, "System.Array Example");
            }

        }
    }
}
