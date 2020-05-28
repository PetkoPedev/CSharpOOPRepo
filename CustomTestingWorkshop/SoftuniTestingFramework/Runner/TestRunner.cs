using SoftuniTestingFramework.Attributes;
using SoftuniTestingFramework.Exeptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SoftuniTestingFramework.Runner
{
    public class TestRunner
    {
        public List<string> Run(string path)
        {
            var listOfResults = new List<string>();


            var testClasses = Assembly
                .LoadFile(path)
                .GetTypes()
                .Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(TestClassAttribute))).ToList();

            foreach (Type classType in testClasses)
            {
                var testMethods = classType.GetMethods()
                    .Where(x => x.CustomAttributes.Any(y => y.AttributeType == typeof(TestMethodAttribute)))
                    .ToList();

                var classInstance = Activator.CreateInstance(classType);

                foreach (var testMethod in testMethods)
                {
                    try
                    {
                        var methodResult = testMethod
                        .Invoke(classInstance, new object[] { });

                        listOfResults.Add($"{testMethod.Name} passed successfully!");
                    }
                    catch (TargetInvocationException e)
                    {
                        listOfResults.Add($"{testMethod.Name} failed! - {e.Message}");
                        
                    }
                }
            }

            return listOfResults;
        }
    }
}
