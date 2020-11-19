using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height;

            string inValue;

            Console.Write("Please enter the height of the rectangle: ");
            inValue = Console.ReadLine();
            height = double.Parse(inValue);
            Console.Write("Please enter the width of the rectangle: ");
            inValue = Console.ReadLine();
            width = double.Parse(inValue);

            double area = height * width;
            double perimeter = 2 * (height + width);

            Console.Clear();
            Console.WriteLine($"Reactangle Height: {height:f2}");
            Console.WriteLine($"Reactangle Width: {width:f2}\n");
           
            Console.WriteLine($"Reactangle Area: {area:f2}");
            Console.WriteLine($"Reactangle Perimeter: {perimeter:f2}");
            Console.ReadKey();
        }
    }
}
