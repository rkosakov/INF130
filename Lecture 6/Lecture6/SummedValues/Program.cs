using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummedValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int intValue;
          
            string inValue = Console.ReadLine();

            if (int.TryParse(inValue, out intValue) == false)
            {
                Console.WriteLine("Wrong input!");
            }
            Console.WriteLine("To stop the loop type -99");
            while (inValue != "-99")
            {
                sum += intValue;
                Console.WriteLine("To stop the loop type -99");
                inValue = Console.ReadLine();

                if (int.TryParse(inValue, out intValue) == false)
                {
                    Console.WriteLine("Wrong input!");
                }
            }

            Console.WriteLine($"The sum is {sum}");
            Console.ReadKey();
        }
    }
}
