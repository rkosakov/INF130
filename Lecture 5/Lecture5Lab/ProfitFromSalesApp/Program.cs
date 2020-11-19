using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitFromSalesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sales = GetInput();
            decimal rate = GetProfitRatioRate(sales);
            decimal profit = CalculateProfit(sales, rate);

            DisplayResult(sales, rate, profit);
        }

        public static decimal GetInput()
        {

            Console.Write("Enter your sales: ");
            decimal grossSalary = decimal.Parse(Console.ReadLine());
            return grossSalary;
        }

        public static decimal GetProfitRatioRate(decimal sales)
        {
            decimal rate;

            if (sales > 10000m)
            {
                rate = 0.045m;
            }
            else if (sales > 5000m)
            {
                rate = 0.04m;
            }
            else if (sales > 1000m)
            {
                rate = 0.035m;
            }
            else if (sales > 0m)
            {
                rate = 0.03m;
            }
            else
            {
                rate = 0.00m;
            }

            return rate;
        }

        public static decimal CalculateProfit(decimal pay, decimal rate)
        {
            return pay * rate;
        }

        public static void DisplayResult(decimal sales, decimal rate, decimal profit)
        {
            if (profit == 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine($"Sales: {sales:c}");
                Console.WriteLine($"Profit ration: {rate:p}");
                Console.WriteLine($"Net Proceeds: {profit:c}");
            }
        }
    }
}
