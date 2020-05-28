using System;
using SoftuniTestingFramework.Runner;
namespace MySpecialApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestRunner testRunner = new TestRunner();
            var resultSet = testRunner.Run(@"C:\Users\Petko Pedev\source\AdvancedOOPRepos\CustomTestingWorkshop\Workshop\bin\Debug\netcoreapp2.1\MySpecialApp.Tests.dll");

            foreach (var item in resultSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
