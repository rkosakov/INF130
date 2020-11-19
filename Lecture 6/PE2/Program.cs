using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfItems = getInput();
            double totalShippingCharges = 0.0;

            while (numberOfItems != -99)
            {
                double shippingCharges = 0.0;

                for (int i = 1; i <= numberOfItems; i++)
                {
                    if (i == 1)
                    {
                        shippingCharges += 2.99;
                    }
                    else if (i >= 2 && i <= 5)
                    {
                        shippingCharges += 1.99;
                    }
                    else if (i >= 6 && i <= 14)
                    {
                        shippingCharges += 1.49;
                    }
                    else if (i >= 15)
                    {
                        shippingCharges += 0.99;
                    }
                }
                MessageBox.Show($"The shipping charge for {numberOfItems} item(s): {shippingCharges:c2}.", "Shipping Charges Application");
                totalShippingCharges += shippingCharges;

                numberOfItems = getInput();
            }


            MessageBox.Show($"The shipping charge for all item(s): {totalShippingCharges:c2}.", "Shipping Charges Application");
            Console.ReadKey();
        }

        public static int getInput()
        {
            Console.WriteLine("Shipping Charges Application\n");

            Console.Write("Please enter the number of items purchased or -99 to finish: ");
            int numberOfItems = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return numberOfItems;
        }
    }
}
