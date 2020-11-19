using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] calories = {{900,750, 1020},
                                {300, 1000, 2700},
                                {500, 700, 2100},
                                {400, 900, 1780},
                                {600, 1200, 1100},
                                {575, 1150, 1900},
                                {600, 1020, 1700}};

            double[] dailyAverage = new double[7];
            double[] mealAverage = new double[3];

            dailyAverage = CalculateAveragePerDay(calories);
            mealAverage = CalculateAveragePerMeal(calories);

            DisplayDailyAverage(dailyAverage);
            DisplayMealAverage(mealAverage);
            DisplayAverageCaloriesPerMeal(calories);
            Console.ReadKey();


        }

        public static double[] CalculateAveragePerDay(int[,] calories)
        {
            int sum = 0;
            double[] dailyAverage = new double[7];

            for (int rows = 0; rows < calories.GetLength(0); rows++)
            {
                for (int colums = 0; colums < calories.GetLength(1); colums++)
                {
                    sum += calories[rows, colums];
                    dailyAverage[rows] = (double)sum / calories.GetLength(1);
                    sum = 0;
                }
            }

            return dailyAverage;
        }

        public static double[] CalculateAveragePerMeal(int[,] calories)
        {
            int sum = 0;
            double[] mealAverage = new double[3];

            for (int c = 0; c < calories.GetLength(1); c++)
            {
                for (int r = 0; r < calories.GetLength(0); r++)
                {
                    sum += calories[r, c];
                    mealAverage[c] = (double)sum / calories.GetLength(0);
                    sum = 0;
                }
            }

            return mealAverage;
        }

        //public static void DisplayAverageCaloriesPerMeal(int[,] calories)
        //{
        //    double sum = 0;

        //    for (int rows = 0; rows < calories.GetLength(0); rows++)
        //    {
        //        for (int colums = 0; colums < calories.GetLength(1); colums++)
        //        {
        //            sum += calories[rows, colums];
        //            Console.WriteLine("\nCalories Average Per Meal: {0:N0}", sum / calories.Length);
        //        }
        //    }
        //}

        public static void DisplayDailyAverage(double[] dailyAverage)
        {
            int dayNumber = 1;
            Console.WriteLine("Calorie Counter");
            Console.WriteLine("Daily Averages");

            foreach (double average in dailyAverage)
            {
                Console.WriteLine("Day {0}: {1,6:N0}", dayNumber, average);
                dayNumber++;
            }
        }

        public static void DisplayMealAverage(double[] mealAverage)
        {
            string[] mealTime = { "Breakfast", "Lunch", "Dinner" };

            Console.WriteLine("\n\nCalorie Counter");
            Console.WriteLine("Meal Averages");

            for (int i = 0; i < mealAverage.Length; i++)
            {
                Console.WriteLine("{0,-10}: {1,6}", mealTime[i], mealAverage[i].ToString("N0"));
            }
        }

        public static void DisplayAverageCaloriesPerMeal(int[,] calories)
        {
            double sum = 0;

            for (int days = 0; days < calories.GetLength(0); days++)
            {
                for (int meals = 0; meals < calories.GetLength(1); meals++)
                {
                    sum += calories[days, meals];
                }
            }
            Console.WriteLine("\nCaloric Average Per Meal: {0:N0}", sum / calories.Length);
        }

    }
}
