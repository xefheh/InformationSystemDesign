using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemDesign
{
    internal class ValidException : Exception 
    {
        public ValidException(string message) : base(message) { } 
    }
}
