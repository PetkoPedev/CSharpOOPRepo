using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidLevelTypeException : Exception
    {
        private const string message = "Invalid Level Type";
        public InvalidLevelTypeException()
            :base(message)
        {
        }

        public InvalidLevelTypeException(string message) : base(message)
        {
        }
    }
}
