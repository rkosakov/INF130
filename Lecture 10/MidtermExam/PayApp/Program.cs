using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double grossWeeklySales;
            const double COMMISSION_RATE = 0.07;
            const double FEDERAL_TAX_RATE = 0.10;
            const double SOCIAL_SECURITY_RATE = 0.15;
            const double RETIREMENT_CONTRIBUTION = 0.05;

            string inValue, name;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your Weekly Sales: ");
            inValue = Console.ReadLine();
            grossWeeklySales = double.Parse(inValue);

            double comisionRate = grossWeeklySales * COMMISSION_RATE;
            double taxRate = grossWeeklySales * FEDERAL_TAX_RATE;
            double socialSecurityRate = grossWeeklySales * SOCIAL_SECURITY_RATE;
            double retirementContributionRate = grossWeeklySales * RETIREMENT_CONTRIBUTION;

            double netSales = grossWeeklySales - (comisionRate + taxRate + socialSecurityRate + retirementContributionRate);

            Console.Clear();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Gross Weekly Sales: {grossWeeklySales:f2}");
            Console.WriteLine($"Commission rate deduction: {comisionRate:f2}");
            Console.WriteLine($"Federal tax rate deduction: {taxRate:f2}");
            Console.WriteLine($"Social security rate deduction: {socialSecurityRate:f2}");
            Console.WriteLine($"Retirement contribution rate deduction: {retirementContributionRate:f2}");
            Console.WriteLine($"Net Weekly Sales: {netSales:f2}");
            Console.ReadKey();

        }
    }
}
