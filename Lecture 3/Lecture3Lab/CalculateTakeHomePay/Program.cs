using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTakeHomePay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter sales rate: ");
            double sales = double.Parse(Console.ReadLine());

            double netSalary = CalculateSalary(sales);
            DisplayData(name, netSalary);

        }

        static double CalculateSalary(double sales)
        {
            double comission = 0.07;
            double fedTax = 0.18;
            double retirementFond = 0.10;
            double socialRate = 0.06;

            double grossSalary = sales * comission;
            return grossSalary - (grossSalary * fedTax) - (grossSalary - retirementFond) - (grossSalary - socialRate);
        }

        static void DisplayData(string name, double netSalary )
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Net Salary: {netSalary:c2}");
            Console.ReadKey();
        }
    }
}
