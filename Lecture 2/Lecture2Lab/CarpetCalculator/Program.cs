using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            const int INCHES_PER_FOOT = 12;
            const string BEST_CARPET = "Berber";
            const string ECONOMY_CARPET = "Pile";

            int roomLengthFeet = 12;
            int roomLengthInches = 2;
            int roomWidthFeet = 14;
            int roomWithInches = 7;

            double roomLength;
            double roomWidth;
            double carpetPrice;
            double numberOfSquareFeet;
            double numberOfSquareYards;
            double totalCost;

            roomLength = roomLengthFeet + (double) roomLengthInches / INCHES_PER_FOOT;
            roomWidth = roomWidthFeet + (double)roomWithInches / INCHES_PER_FOOT;

            numberOfSquareFeet = roomLength * roomWidth;

            numberOfSquareYards = numberOfSquareFeet / SQ_FT_PER_SQ_YARD;

            carpetPrice = 27.95;

            totalCost = numberOfSquareYards * carpetPrice;

            Console.WriteLine($"The cost of {BEST_CARPET} is {totalCost:C2}"); 

            carpetPrice = 15.95;

            totalCost = numberOfSquareYards * carpetPrice;

            Console.WriteLine($"The cost of {ECONOMY_CARPET} is {totalCost:C2}");

            Console.ReadKey();

        }
    }
}
