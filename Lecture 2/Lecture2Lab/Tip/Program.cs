using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the bill: ");
            double bill = double.Parse(Console.ReadLine());
            Console.WriteLine();
            const int fifteenP = 15;
            const int twentyP = 20;

            double amountFrom15P = bill * ((double)fifteenP / 100);
            double amountFrom20P = bill * ((double)twentyP / 100);

            double totalFrom15P = bill - amountFrom15P;
            double totalFrom20P = bill - amountFrom20P;

            Console.WriteLine($"The bill is: {bill:c2}");
            Console.WriteLine();
            Console.WriteLine("Tip from 15 % of the bill");
            Console.WriteLine($"Amount added: {amountFrom15P:c2}");
            Console.WriteLine($"Total Amount: {totalFrom15P:c2}");
            Console.WriteLine();
            Console.WriteLine("Tip from 20 % of the bill");
            Console.WriteLine($"Amount added: {amountFrom20P:c2}");
            Console.WriteLine($"Total Amount: {totalFrom20P:c2}");

            Console.ReadKey();

        }
    }
}
