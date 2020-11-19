using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the bill: ");
            double bill = double.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());

            CalculateTip(bill, percentage);
        }

        static void CalculateTip(double bill, double percentage)
        {
            double tip = bill * (percentage / 100);

            double totalAmount = bill + tip;

            Console.WriteLine($"The bill is: {bill:c2}");
            Console.WriteLine($"The tip amount is: {tip:c2}");
            Console.WriteLine($"The total amount is: {totalAmount:c2}");
            Console.ReadKey();
        }
    }
}
