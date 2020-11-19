using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream filStream;
            BinaryWriter binWriter;

            Console.WriteLine("Enter name of the file");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                Console.WriteLine("File - {0} already exists!", fileName);

            }
            else
            {
                filStream = new FileStream(fileName, FileMode.CreateNew);
                binWriter = new BinaryWriter(filStream);
                decimal aValue = 2.16m;
                binWriter.Write("Simple run ");
                for (int i = 0; i <= 10; i++)
                {
                    binWriter.Write(i);
                    binWriter.Write(aValue);

                    binWriter.Close();
                    filStream.Close();
                    Console.WriteLine("File Created successfully!");
                }
                Console.ReadKey();
            }

        }
    }
}
