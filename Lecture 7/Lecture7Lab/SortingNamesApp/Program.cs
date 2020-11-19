using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingNamesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[100];

            PrompForInput(names);

            names.OrderBy(n => n);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();

        }

        public static void PrompForInput(string[] names)
        {
            string input;
            int index = 0;
            do
            {
                Console.WriteLine("\nEnter Last Name followed by a space and then the First Name.");
                Console.WriteLine("\t To exit type Enter key...");
                Console.WriteLine();
                input = Console.ReadLine();
                names[index] = input;
                index++;

            } while (input != string.Empty);
        }
    }
}
