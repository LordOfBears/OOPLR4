using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR4
{
    internal class MarkException : Exception
    {
        public MarkException(string message) : base(message) { }
    }
}
