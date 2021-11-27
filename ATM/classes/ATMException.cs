using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ATMException : Exception
    {
        public ATMException() : base() { }

        public ATMException(string error) : base(error) { }
           
    }
}
