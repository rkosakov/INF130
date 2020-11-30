using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryFileAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream filStream;
            BinaryReader binRearder;

            Console.Write("Enter the name of the file: ");
            string fileName = Console.ReadLine();

            try
            {
                filStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                binRearder = new BinaryReader(filStream);
                RetriveAndDisplayData(binRearder);

                binRearder.Close();
                filStream.Close();



            }
            catch (FileNotFoundException exc)
            {

                Console.WriteLine(exc.Message); 
            }
            catch (InvalidDataException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (EndOfStreamException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();
        }

        public static void RetriveAndDisplayData(BinaryReader binRearder)
        {
            Console.WriteLine(binRearder.ReadString());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(binRearder.ReadInt32());
            }

            Console.WriteLine(binRearder.ReadDecimal());
        }
    }
}
