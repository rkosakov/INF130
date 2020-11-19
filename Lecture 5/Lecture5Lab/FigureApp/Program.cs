using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace FigureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Figure! \nPlease choose among Circle, Triangle, Rectangle, Square and Cylinder: ");
            string figure = Console.ReadLine();
            double result = 0;

            switch (figure)
            {
                case "Circle":
                case "circle":
                    Console.Write("Enter the radius of the circle: ");
                    double radius = double.Parse(Console.ReadLine());
                    result = CalculateCircleArea(radius);
                    break;
                case "Triangle":
                case "triangle":
                    Console.Write("Enter the value of the base of the triangle: ");
                    double triangleBase = double.Parse(Console.ReadLine());
                    Console.Write("Enter the value of the height of the triangle: ");
                    double height = double.Parse(Console.ReadLine());
                    result = CalculateTriangleArea(triangleBase, height);
                    break;
                case "Rectangle":
                case "rectangle":
                    Console.Write("Enter the value of first side of the Rectangle: ");
                    double firstSide = double.Parse(Console.ReadLine());
                    Console.Write("Enter the value of second side of the Rectangle: ");
                    double secondSide = double.Parse(Console.ReadLine());
                    result = CalculateRectangleArea(firstSide, secondSide);
                    break;
                case "Square":
                case "square":
                    Console.WriteLine("Enter the value of the side of the Square: ");
                    double side = double.Parse(Console.ReadLine());
                    break;
                case "Cylinder":
                case "cylinder":
                    Console.Write("Enter the radius of the cylinder: ");
                    double radiusOfCylinder = double.Parse(Console.ReadLine());
                    Console.Write("Enter the value of the height of the cylinder: ");
                    double heightOfCylinder = double.Parse(Console.ReadLine());
                    result = CalculateCylinderArea(radiusOfCylinder, heightOfCylinder);
                    break;
                default:
                    Console.WriteLine("Invalid Figure");
                    break;

            }
            Console.WriteLine($"The Area of the {figure} is {result:f2}");
            Console.ReadKey();
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double CalculateTriangleArea(double triangleBase, double height)
        {
            return (triangleBase * height) / 2;
        }

        static double CalculateRectangleArea(double firstSide, double secondSide)
        {
            return firstSide * secondSide;
        }

        static double CalculateSquareArea(double side)
        {
            return Math.Pow(side, 2);
        }

        static double CalculateCylinderArea(double radius, double height)
        {
            return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
        }
    }
}
