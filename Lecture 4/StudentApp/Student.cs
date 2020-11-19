using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student
    {
        private string studentName;
        private string studentLastName;
        private string studentNumber;
        private int score1;
        private int score2;
        private int score3;
        private string major;

        public Student()
        {

        }

        public Student(string sID)
        {
            studentNumber = sID;
        }

        public Student(string sID, string lastName, string fisrtName)
        {
            studentNumber = sID;
            studentName = fisrtName;
            studentLastName = lastName;
        }

        public Student(string sId, string lastName, string name, int score1, int score2, int score3, string major)
        {
            this.StudentName = name;
            this.StudentLastName = lastName;
            this.StudentNumber = sId;
            this.Score1 = score1;
            this.Score2 = score2;
            this.Score3 = score3;
            this.Major = major;
        }

        

        public string StudentName
        {

            get { return studentName; }
            set { studentName = value; }
        }
        public string StudentLastName
        {

            get { return studentLastName; }
            set { studentLastName = value; }
        }
        public string StudentNumber
        {

            get { return studentNumber; }
            set { studentNumber = value; }
        }

        public int Score1
        {
            get
            {
                return score1;
            }

            set
            {
                score1 = value;
            }
        }

        public int Score2
        {
            get
            {
                return score2;
            }

            set
            {
                score2 = value;
            }
        }
        public int Score3
        {
            get
            {
                return score3;
            }

            set
            {
                score3 = value;
            }
        }

        public string Major
        {

            get { return major; }
            set { major = value; }
        }

        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / 3.0;
        }

        public override string ToString()
        {
            return "Name: " +
                studentName + " " + StudentLastName + "\n" +
                "Major: " + major + "\n" +
                "Score Average: " + CalculateAverage().ToString("F2");
        }


    }
}
