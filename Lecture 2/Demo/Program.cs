using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount;
            int age = 20;

            double grade = 123.12;
            float f1 = 123.65f;
            string twoLines = "Line 1\nLine 2";
            char c1 = '\u005A';

            string firstName = "Rosen";
            string lastName = "Kosakov";
           //string result;
           //result = firstName + " " + lastName;

            int num = 100;
            Console.WriteLine(num++);
            Console.WriteLine(num);
            Console.WriteLine(++num);

            int count = 0;
            int firstNum = 10;
            int result = 0;

            count++;

            result = count++ * --firstNum + 100;
            Console.WriteLine(result);
            

            
            Console.ReadKey();
        }
    }
}
