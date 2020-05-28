using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidAppenderTypeException : Exception
    {
        private const string EXC_MSG = "Invalid Appender Type";
        public InvalidAppenderTypeException()
            : base(EXC_MSG)
        {
        }

        public InvalidAppenderTypeException(string message) : base(message)
        {
        }
    }
}
