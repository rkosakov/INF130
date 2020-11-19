using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Demo2
{
    class Program
    {
        public static void DisplayInstruction()
        {
            WriteLine("This program will determine" + "how much carpet to purchase.");
            WriteLine();
            WriteLine("You will be asked to enter to enter the" + "size of the room and");
            WriteLine("the price of the carpet, " + "in price per square yards.");
            WriteLine();
        }

        public static void DisplayResult(double squareYards, double pricePerSquareYard)
        {
            Write("Total Square Yards needed: ");
            WriteLine("{0:N2}", squareYards);
            Write("Total Cost at {0:C} ", pricePerSquareYard);
            WriteLine(" per Square Yard: {0:C}", (squareYards * pricePerSquareYard));

        }

        public static double GetLength()
        {
            string inputValue;
            int feet, inches;
            Write("Enter the Length in feet: ");
            inputValue = ReadLine();
            feet = int.Parse(inputValue);
            Write("Enter the Length in inches: ");
            inputValue = ReadLine();
            inches = int.Parse(inputValue);
            return (feet + (double)inches / 12);
        }


        static void Main(string[] args)
        {
            double roomWidth, roomLength, pricePerSqYard,
                         noOfSquareYards;
            DisplayInstruction();

            // Call getDimension( ) to get length
            roomLength = GetLength("Length");

            roomWidth = GetDimension("Width");
            pricePerSqYard = GetPrice();
            noOfSquareYards =
                   DetermineSquareYards(roomWidth, roomLength);
            DisplayResults(noOfSquareYards, pricePerSqYard);


        }
    }
}
