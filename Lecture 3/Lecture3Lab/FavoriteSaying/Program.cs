using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteSaying
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your favorite saying: ");
            string saying = Console.ReadLine();

            DisplayMessage(name, saying);
        }

        static void DisplayMessage(string name, string saying)
        {
            Console.WriteLine();
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite saying: {saying}");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><>");

            Console.ReadKey();
        }
    }
}
