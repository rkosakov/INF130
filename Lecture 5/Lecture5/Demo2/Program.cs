using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2, largestOne;

            InputValue(out value1, out value2);

            if (value1 > value2)
            {
                largestOne = value1;
            }
            else
            {
                largestOne = value2;
            }

            Console.WriteLine($"The largest one is: {largestOne}");

            Console.ReadKey();
        }

        public static void InputValue(out int v1, out int v2)
        {
            string inValue;

            Console.Write("Enter the first value: ");

            inValue = Console.ReadLine();

            if (int.TryParse(inValue, out v1) == false)
            {
                Console.WriteLine("Wrong input!");
            }

            Console.Write("Enter the second value: ");

            inValue = Console.ReadLine();

            if (int.TryParse(inValue, out v2) == false)
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
