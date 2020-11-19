using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondsConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            string result = ConvertSeconds(seconds);

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string ConvertSeconds(int seconds)
        {
            int initialSeconds = seconds;
            int hours = initialSeconds / 3600;
            initialSeconds %= 3600; 
            int minutes = initialSeconds / 60;
            initialSeconds %= 60;

            return $"{seconds} seconds is {hours} hours, {minutes} minutes and {initialSeconds} seconds.";
        }
    }
}
