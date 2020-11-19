using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the miles: ");
            double miles = double.Parse(Console.ReadLine());

            double feet = miles * 5280;
            double kilometers = miles * 1.609;

            Console.WriteLine();
            Console.WriteLine($"Miles Entered: {miles:f2} mi.");
            Console.WriteLine($"Total Feet: {feet:f2} ft.");
            Console.WriteLine($"Total Kilometers: {kilometers:f2} km.");

            Console.ReadKey();
        }
    }
}
