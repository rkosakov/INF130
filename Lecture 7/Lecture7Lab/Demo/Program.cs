using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo
{
    class RainfallApp
    {
        static void Main(string[] args)
        {

            double[] rain = new double[12];

            string[] monthName = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            rain = GetRainfallAmount(rain, monthName);

            ProduceReport(rain, monthName);

            Console.ReadKey();

        }

        public static double[] GetRainfallAmount(double[] rain, string[] monthName)
        {
            string inValue;

            for (int i = 0; i < rain.Length; i++)
            {
                Console.Write("Please enter the rainfall amount of the {0}: ", monthName[i]);
                inValue = Console.ReadLine();

                while (double.TryParse(inValue, out rain[i]) == false)
                {
                    Console.WriteLine("Wrong input!");
                    inValue = Console.ReadLine();
                }
            }

            return rain;
        }

        public static void ProduceReport(double[] rain, string[] monthName)
        {
            double meanRainfall;

            meanRainfall = rain.Average();

            Console.Clear();

            Console.WriteLine("\t\tRainfall App");
            Console.WriteLine("\nAverage rainfall: {0:f1}", meanRainfall);

            Console.WriteLine("\n{0, -9} {1, 9} {2, 8}", "Month", "Rainfall Amount", "Variance");

            for (int i = 0; i < rain.Length; i++)
            {

                Console.WriteLine("{0, -9} {1, 9} {2, 8}", monthName[i], rain[i], Math.Abs(rain[i] - meanRainfall).ToString());
            }
        }

        

    }
}
