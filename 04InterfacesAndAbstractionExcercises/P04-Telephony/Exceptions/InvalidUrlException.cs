using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Telephony.Exceptions
{
    public class InvalidUrlException : Exception
    {
        private const string ExceptionMessage = "Invalid URL!";
        public InvalidUrlException()
            :base(ExceptionMessage)
        {

        }

        public InvalidUrlException(string message)
            :base(message)
        {

        }
    }
}
