﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SoftuniTestingFramework.Exeptions
{
    public class TestException : Exception
    {
        public TestException(string message)
            : base(message)
        {

        }
    }
}
