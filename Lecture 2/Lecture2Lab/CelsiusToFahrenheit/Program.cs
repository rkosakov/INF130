using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the degrees in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = ((9.0 / 5.0) * celsius) + 32.0;

            Console.WriteLine($"The degrees in Fahrenheit is: {fahrenheit:f2}");

            Console.ReadKey();

        }
    }
}
