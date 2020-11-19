using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stateAbbrev;

            Console.WriteLine("Enter the state abrreviation.");
            Console.WriteLine("Its full name will be displayed.");
            Console.WriteLine();

            stateAbbrev = Console.ReadLine();

            switch (stateAbbrev)
            {
                case "AL":
                    Console.WriteLine("Alabama");
                    break;
                case "FL":
                    Console.WriteLine("Florida");
                    break;
                case "TX":
                    Console.WriteLine("Texas");
                    break;
                default:
                    Console.WriteLine("No match");
                    break;
            }

            Console.ReadKey();
        }
    }
}
