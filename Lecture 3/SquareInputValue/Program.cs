using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SquareInputValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStringValue;
            double aValue, result;

            Write("Enter a number to be squared ");

            inputStringValue = ReadLine();

            aValue = double.Parse(inputStringValue);

            result = Math.Pow(aValue, 2);

            WriteLine("{0} squared is {1}", aValue, result);

            ReadKey();
        }
    }
}
