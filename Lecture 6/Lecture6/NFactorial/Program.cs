using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            string moreData;
            int n;

            DisplayInformation();

            do
            {
                n = InputN();
                CalculateNFactorialIteratively(n, out result);
                DisplayNFactorial(n, result);
                moreData = PromptForMoreCalculations();

            } while ();
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("n1 represents the product of the first n integers");
        }

        public static void CalculateNFactorialIteratively(int n, out int result)
        {
            result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
        }

        public static int InputN()
        {
            string inValue;
            int n;

            Console.Write("Enter the number to use to compute n!: ");
            inValue = Console.ReadLine();

            if (int.TryParse(inValue, out n) == false)
            {
                Console.WriteLine("Wrong input");
            }

            return n;
        }

        public static void DisplayNFactorial(int n, int result)
        {
            Console.WriteLine($"{n}! {result}.");
        }

        public static string PromptForMoreCalculations()
        {
            string moreData;
            Console.Write("Enter y for more calculations");
            moreData = Console.ReadLine();

            return moreData;
        }
    }
}
