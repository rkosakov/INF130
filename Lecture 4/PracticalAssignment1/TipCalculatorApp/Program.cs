using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the total charges for the food purchases: ");//asking the user to input the amount of food purchase

            double foodPurchase = double.Parse(Console.ReadLine());//reading the input

            double taxAmount = CalculateTaxes(foodPurchase);//calculating the tax amount by invoking the method
            double tipAmountOf15P = CalculateTip(foodPurchase, 0.15, taxAmount);//calculating the tip amout with 15% tip by invoking the method
            double tipAmountOf20P = CalculateTip(foodPurchase, 0.20, taxAmount);//calculating the tip amout with 20% tip by invoking the method

            DisplayResult(foodPurchase, taxAmount, tipAmountOf15P, tipAmountOf20P);//invoking the DisplayResult method to display the result

        }

        static double CalculateTaxes(double foodPurchase)//method to calculate the taxAmount with one parameter the food purchase amount
        {
            double taxAmount = foodPurchase * 0.09;//calculating the tax amount with 9% tax rate

            return taxAmount;//returning the tax rate
        }

        static double CalculateTip(double foodPurchase, double tipRate, double taxAmount)//method to calculate the tipAmount with three parameters the food purchase amount, the tip rate (15% or 20%) and the tax amount
        {
            double tipAmount = (foodPurchase + taxAmount) * tipRate;//calculating the tip amount

            return tipAmount;//returning the tip rate
        }

        static void DisplayResult(double foodPurchase, double taxAmount, double tipAmountOf15P, double tipAmountOf20P)//method to display the result that takes the food purchase amount, the tip charged amount both 15% and 20% and the tax amount
        {
            Console.WriteLine();
            Console.WriteLine("             Tip Calculator App\n");
            Console.WriteLine($"Total Before Taxes and Tip:     {foodPurchase:c2}");
            Console.WriteLine($"Tax (9 %):                      {taxAmount:c2}");
            Console.WriteLine($"Tip (15 %):                     {tipAmountOf15P:c2}");
            Console.WriteLine("                              --------");
            Console.WriteLine($"Total Including Taxes with  15 % Tip:       {(foodPurchase + taxAmount + tipAmountOf15P):c2}\n");
            Console.WriteLine($"Tip (20 %):                     {tipAmountOf20P:c2}");
            Console.WriteLine("                              --------");
            Console.WriteLine($"Total Including Taxes with  20 % Tip:       {(foodPurchase + taxAmount + tipAmountOf20P):c2}");

            Console.ReadKey();
        }

    }
}
