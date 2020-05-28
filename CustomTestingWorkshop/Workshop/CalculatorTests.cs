using SoftuniTestingFramework.Asserts;
using SoftuniTestingFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySpecialApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void ShouldSumSuccessfullyTwoValues()
        {
            //arrange
            int a = 10;
            int b = 20;
            int expectedResult = 30;

            //act
            Calculator calculator = new Calculator();
            var actualResult = calculator.Sum(a, b);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void ShouldDivideSuccessfullyTwoValues()
        {
            //arrange
            int a = 10;
            int b = 10;
            int expectedResult = 1;

            //act
            Calculator calculator = new Calculator();
            var actualResult = calculator.Divide(a, b);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
