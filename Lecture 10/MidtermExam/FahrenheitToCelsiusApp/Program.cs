using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitToCelsiusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            string inValue;

            Console.Write("Please enter the degrees in Fahrenheit: ");
            inValue = Console.ReadLine();
            fahrenheit = double.Parse(inValue);

            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.Clear();

            Console.WriteLine($"Degrees in Fahrenheit: {fahrenheit:f2}");
            Console.WriteLine($"Degrees in Celsius: {celsius:f2}");
            Console.ReadKey();

        }
    }
}
