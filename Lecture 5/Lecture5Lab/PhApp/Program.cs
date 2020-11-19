using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter th PH level of the water: ");
            double phLevel = double.Parse(Console.ReadLine());

            if (phLevel <= 0 || phLevel > 14)
            {
                Console.WriteLine("Error");
            }
            else if (phLevel >= 1 && phLevel < 7)
            {
                Console.WriteLine("Acidic level");
                Console.WriteLine("You need Alkali to level out the pH!");
            }
            else if (phLevel == 7)
            {
                Console.WriteLine("Neutral level");
            }
            else if (phLevel > 7 && phLevel <= 14)
            {
                Console.WriteLine("Alkaline level");
                Console.WriteLine("You need Acid to level out the pH!");
            }

            Console.ReadKey();
        }
    }
}
