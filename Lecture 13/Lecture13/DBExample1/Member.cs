using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExample1
{
    class Member
    {
        private string id;
        private string firstName;
        private string lastName;
        private string phoneNumber;

        // Constructors
        public Member()
        {

        }

        public Member(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;

        }

        // Properties
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
