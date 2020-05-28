using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Telephony.Exceptions
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string ExceptionMessage = "Invalid number!";
        public InvalidPhoneNumberException()
            :base(ExceptionMessage)
        {
        }

        public InvalidPhoneNumberException(string message) 
            : base(message)
        {
        }
    }
}
