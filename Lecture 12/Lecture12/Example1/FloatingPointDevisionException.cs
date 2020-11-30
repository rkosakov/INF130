using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class FloatingPointDevisionException : ApplicationException
    {
        public FloatingPointDevisionException(string exceptionType)
            :base(exceptionType)
        {

        }
    }
}
