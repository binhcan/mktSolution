using System;
using System.Collections.Generic;
using System.Text;

namespace mktSolution.Utilities.Exceptions
{
    public class MktException : Exception
    {
        public MktException()
        {
        }

        public MktException(string message)
            : base(message)
        {
        }

        public MktException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
