using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelPricesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerLiter = GetInput("liter");
            double pricePerGallon = GetInput("gallon");

            double comparablePrice = ConvertLitersToGallons(pricePerLiter);

            DispleyResult(pricePerLiter, pricePerGallon, comparablePrice);
        }

        public static double GetInput(string measure)
        {
            double price;
            Console.Write($"Enter the price of the fuel per {measure}: ");

            if (double.TryParse(Console.ReadLine(), out price) == false)
            {
                Console.WriteLine("Invalid data");
            }

            return price;
        }

        public static double ConvertLitersToGallons(double pricePerLiter)
        {
            return pricePerLiter * 3.7854;
        }

        public static void DispleyResult(double pricePerLiter, double pricePerGallon, double comparablePrice)
        {
            Console.WriteLine($"Price per litter is: {pricePerLiter:c2}");
            Console.WriteLine($"Price per gallon is: {pricePerGallon:c2}");
            Console.WriteLine($"The Converted price is: {comparablePrice:c2}");

            string economical = String.Empty;

            if (comparablePrice > pricePerGallon)
            {
                economical = "gallon";
            }

            else
            {
                economical = "liter";
            }
            Console.WriteLine($"The price per {economical} is more economical! ");
        }


    }
}
