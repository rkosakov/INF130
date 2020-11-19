using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of scores: ");
            int numberOfScores = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numberOfScores; i++)
            {
                Console.Write("Enter a score: ");
                int score = int.Parse(Console.ReadLine());
                sum += score;
            }

            double average = (double)sum / numberOfScores;

            Console.WriteLine($"The Average score is: {average:f2}");
        }
    }
}
