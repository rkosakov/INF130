using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1 = 0;
            double value2 = 0;
            double answer;

            try
            {
                answer = GetResults(value1, value2);
            }
            catch (FloatingPointDevisionException exceptionObj)
            {
                Console.WriteLine(exceptionObj.Message);
                
            }
            catch 
            {
                Console.WriteLine("Something else happened!");

            }
            Console.ReadKey();
        }

        static double GetResults(double value1, double value2)
        {
            if (value2 < 0.000000001)
            {
                FloatingPointDevisionException excepObj = new FloatingPointDevisionException("Exception typre: Floating-Point devision by 0!");

                throw excepObj;
            }

            return value1 / value2;
        } 
    }
}
