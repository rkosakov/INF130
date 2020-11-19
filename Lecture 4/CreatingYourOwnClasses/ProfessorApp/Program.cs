using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter professor's number: ");
            string number = Console.ReadLine();

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Rating 1: ");
            int rating1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Rating 2: ");
            int rating2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Rating 3: ");
            int rating3 = int.Parse(Console.ReadLine());

            ProfessorRating professor1 = new ProfessorRating(number, firstName, lastName, rating1, rating2, rating3);

            Console.WriteLine(professor1.ToString());

            ProfessorRating professor2 = new ProfessorRating();

            professor2.Number = "4565";

            Console.WriteLine(professor2.ToString());
           


        }
    }
}
