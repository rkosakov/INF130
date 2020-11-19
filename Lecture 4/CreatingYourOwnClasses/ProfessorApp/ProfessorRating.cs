using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProfessorApp
{
    class ProfessorRating
    {
        private string number;
        private string firstName;
        private string lastName;
        private int rating1;
        private int rating2;
        private int rating3;

        public string Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Rating1 { get; set; }

        public int Rating2 { get; set; }

        public int Rating3 { get; set; }

        public double GetAverageRaiting()
        {
            return (Rating1 + Rating2 + Rating3) / (double)3;
        }

        public override string ToString()
        {
            return $"Professor's Number: {Number}\n Professor Name: {FirstName} {LastName}\n Easiness: {Rating1}\n Helpfulness: {Rating2}\n Clarity: {Rating3} \n Average Rating: {GetAverageRaiting().ToString("f2")}\n";
        }

        public ProfessorRating()
        {

        }

        public ProfessorRating(string number, string firstName, string lastName)
        {
            this.Number = number;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public ProfessorRating(string number, string firstName, string lastName, int rating1, int rating2, int rating3)
        {
            this.Number = number;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Rating1 = rating1;
            this.Rating2 = rating2;
            this.Rating3 = rating3;
        }
        public ProfessorRating(string number, string firstName, string lastName, int rating1)
        {
            this.Number = number;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Rating1 = rating1;

        }
        public ProfessorRating(string number, string firstName, string lastName, int rating1, int rating2)
        {
            this.Number = number;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Rating1 = rating1;
            this.Rating2 = rating2;

        }

        public ProfessorRating(string number)
        {
            this.Number = number;
        }


    }
}
