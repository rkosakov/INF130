using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StudentApp
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("123", "Kosakov", "Rosen");
            Student student3 = new Student("123", "Kosakov", "Rosen", 6, 6, 6, "COS");

            student2.Score1 = 6;
            student2.Score2 = 4;
            student2.Score3 = 5;

            Console.WriteLine(student2.StudentName);
            Console.WriteLine(student3);
            Console.ReadKey();
        }
    }
}
