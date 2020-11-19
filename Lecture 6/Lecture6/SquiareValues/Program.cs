using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;

            do
            {
                Console.Write("\t" + counter + "\t" + Math.Pow(counter, 2));
                counter--;
            }
            while (counter > 6);

            Console.ReadKey();
        }
    }
}
