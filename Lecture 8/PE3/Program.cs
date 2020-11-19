using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PE3
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayInstructions();

            int[] scores = GetInput();

            scores = scores.OrderBy(x => x).ToArray();
            Console.Clear();
            int highestScore = scores[scores.Length - 1];
            int lowestScore = scores[0];
            Console.WriteLine();
            Console.WriteLine("\t\t\tHomework app");
            Console.WriteLine($"Highest score: {highestScore}");
            Console.WriteLine($"Lowest score: {lowestScore}");

            scores = scores.Where(i => i != highestScore).ToArray();
            scores = scores.Where(i => i != lowestScore).ToArray();
            
            double average = scores.Average();

            Console.WriteLine($"Average Score (excluding lowest & highest scores): {average:f1}");

            Console.ReadKey();

        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("You will be prompted to enter homework scores.     ");
            Console.WriteLine("Valid values are 0 through 100.");
            Console.WriteLine("The highest and lowest scores will be discarded.  ");
            Console.WriteLine("Average is calculated (and displayed) using remaining values.");
            Console.WriteLine("************************************************************************");
        }

        public static int[] GetInput()
        {
            string inValue;
            Console.Write("Please enter the number of scores: ");
            inValue = Console.ReadLine();
            int numberOfScores = int.Parse(inValue);

            int[] scores = new int[numberOfScores];
            int score;



            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("Please enter homework score [0 to 100]: ");
                inValue = Console.ReadLine();
                score = int.Parse(inValue);

                scores[i] = score;

            }
            return scores;
        }


    }
}
