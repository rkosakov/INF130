using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHomePay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the commision rate: ");
            double commisionRate = double.Parse(Console.ReadLine());
            Console.Write("Enter the weekly sales: ");
            double sales = double.Parse(Console.ReadLine());
            Console.Write("Enter the tax rate: ");
            double taxRate = double.Parse(Console.ReadLine());
            Console.Write("Enter the social security rate: ");
            double socialSecurityRate = double.Parse(Console.ReadLine());
            Console.Write("Enter the retirement fund contribution rate: ");
            double retirementFundContributionRate = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double grossSalary = (commisionRate / 100) * sales;
            double taxTaken = (taxRate / 100) * grossSalary;
            double socialSecurityTaken = (socialSecurityRate / 100) * grossSalary;
            double retirementFundsTaken = (retirementFundContributionRate / 100) * grossSalary;

            double netSalary = grossSalary - taxTaken - socialSecurityTaken - retirementFundsTaken;

            Console.WriteLine($"Total Gross salary is: {grossSalary:c2}");
            Console.WriteLine($"Total tax taken: {taxTaken:c2}");
            Console.WriteLine($"Total Social security contribution: {socialSecurityTaken:c2}");
            Console.WriteLine($"Total Retirement fund contribution: {retirementFundsTaken:c2}");
            Console.WriteLine($"Total Net salary is: {netSalary:c2}");
            Console.ReadKey();

        }
    }
}
