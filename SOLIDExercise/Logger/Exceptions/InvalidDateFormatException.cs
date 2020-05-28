using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidDateFormatException : Exception
    {
        private const string message = "Invlalid DateTime format";
        public InvalidDateFormatException()
            :base(message)
        {
        }

        public InvalidDateFormatException(string message) 
            : base(message)
        {
        }

        public InvalidDateFormatException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
