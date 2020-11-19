using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "BirdOfParadise.jpg";
            if (File.Exists(fileName))
            {
                Console.WriteLine($"File name: {fileName}");
                Console.WriteLine($"Atributes: {File.GetAttributes(fileName)}");
                Console.WriteLine($"Created: {File.GetCreationTime(fileName)}");
                Console.WriteLine($"Last Accessed: {File.GetLastAccessTime(fileName)}");


            }

            DirectoryInfo dr = new DirectoryInfo(".");
            Console.WriteLine($"Current directory: \n{Directory.GetCurrentDirectory()}");
            Console.WriteLine("File Name".PadRight(52) + "Size".PadRight(10) + "Creation Time");
            foreach (FileInfo fil in dr.GetFiles("*.*"))
            {
                string name = fil.Name;
                long size = fil.Length;
                DateTime creationTime = fil.CreationTime;

                Console.WriteLine("{0} {1, 12:N0} {2, 20:g}", name.PadRight(45), size, creationTime);
            }
            Console.ReadKey();
        }
    }
}
