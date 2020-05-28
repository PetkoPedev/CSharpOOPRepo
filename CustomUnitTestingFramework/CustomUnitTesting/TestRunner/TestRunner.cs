using System;
using System.Collections.Generic;
using System.Text;

namespace CustomUnitTesting.TestRunner
{
    public class TestRunner
    {
        private readonly ICollection<string> resultInfo;

        public TestRunner(string resultInfo)
        {
            this.resultInfo = resultInfo;
        }
    }
}
