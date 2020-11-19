using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the retail price: ");
            double price = double.Parse(Console.ReadLine());

            const int DISCOUNT = 15;

            double discount = price * ((double) DISCOUNT / 100);

            double discountedPrice = price - discount;

            Console.WriteLine($"The original price was: {price:c2}");
            Console.WriteLine($"The discounted price is: {discountedPrice:c2}");
            Console.WriteLine($"The savings is: {discount:c2}");
            Console.ReadKey();
        }
    }
}
