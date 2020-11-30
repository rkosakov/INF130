using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "BirdOfParadise.jpg";

            if (File.Exists(fileName))
            {
                Console.WriteLine($"File Name: {fileName}");
                Console.WriteLine($"File Attributes: {File.GetAttributes(fileName)}");
                Console.WriteLine($"File Created: {File.GetCreationTime(fileName)}");
                Console.WriteLine($"Last Accessed: {File.GetLastAccessTime(fileName)}");
            }
            else
            {
                Console.WriteLine($"File {fileName} not found");
            }

            Console.WriteLine("\n\n\n");

            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine($"Current Directory:\n{Directory.GetCurrentDirectory()}\n");
            Console.WriteLine($"File Name".PadRight(52) + "Size".PadRight(10) + "Creation Time");
            foreach (FileInfo file in dir.GetFiles("*.*"))
            {
                string name = file.Name;
                long size = file.Length;
                DateTime creationTime = file.CreationTime;

                Console.WriteLine($"{name.PadRight(45)} {size, 12:N0}{creationTime, 20:g}");
            }
            Console.ReadKey();
        }
    }
}
