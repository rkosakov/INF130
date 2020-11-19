using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    class BonusCalculator
    {
        static void Main(string[] args)
        {
            string inValue;
            decimal saleaForYear;
            decimal bonusAmount = 0M;

            Console.WriteLine("Do you get a bonus this year?");
            Console.WriteLine();

            Console.WriteLine("To determine if you are due one, ");
            Console.Write("enter your gross alter figure: ");

            inValue = Console.ReadLine();

            saleaForYear = Convert.ToDecimal(inValue);

            if (saleaForYear > 50000.0M)
            {
                Console.WriteLine();

                Console.WriteLine("Yes...you get a bonus!");
                bonusAmount = 1000.0M;

            }

            Console.WriteLine($"Bonus for the year: {bonusAmount:c0}");

            Console.ReadKey();


        }
    }
}
