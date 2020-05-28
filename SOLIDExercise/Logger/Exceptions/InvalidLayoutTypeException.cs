using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidLayoutTypeException : Exception
    {
        private const string message = "Invalid Layout Type";
        public InvalidLayoutTypeException()
            :base(message)
        {
        }

        public InvalidLayoutTypeException(string message) : base(message)
        {
        }
    }
}
