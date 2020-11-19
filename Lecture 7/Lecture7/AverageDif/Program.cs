using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AverageDif
{
    class AverageDif
    {
        static void Main(string[] args)
        {
            int total = 0;
            double avg, distance;
            string inValue;
            int[] score = new int[10];

            for (int i = 0; i < score.Length; i++)
            {
                Console.Write("Enter score {0}: ", i + 1);

                inValue = Console.ReadLine();

                if (int.TryParse(inValue, out score[i]) == false)
                {
                    Console.WriteLine("Wrong input!");
                }
            }

            foreach (int num in score)
            {
                total += num;
            }

            avg = (double)total / score.Length;

            Console.WriteLine();

            Console.WriteLine("Score\tDist. from Avg.");

            for (int i = 0; i < score.Length; i++)
            {
                distance = Math.Abs((avg - score[i]));

            Console.WriteLine("{0}\t\t{1}", score[i], distance.ToString("F0"));
            }

            Console.ReadKey();
        }
    }
}
