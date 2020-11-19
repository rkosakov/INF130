using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the height of the rectangle: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());

            double perimeter = CalculatePerimeter(height, width);
            double area = CalculateArea(height, width);

            DisplayData(height, width, perimeter, area);
        }

        static double CalculatePerimeter(double height, double width)
        {
            return 2 * height + 2 * width;
        }

        static double CalculateArea(double height, double width)
        {
            return height * width;
        }

        static void DisplayData(double height, double width, double perimeter, double area)
        {
            Console.WriteLine($"The Height is: {height:f2}");
            Console.WriteLine($"The Width is: {width:f2}");
            Console.WriteLine($"The Perimeter is: {perimeter:f2}");
            Console.WriteLine($"The Area is: {area:f2}");
            Console.ReadKey();
        }
    }
}
