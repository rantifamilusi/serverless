using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Xunit;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;

using HelloNameFunction;
using HelloNameFunction.Model;

namespace HelloNameFunction.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {

            // Invoke the lambda function and confirm the string was upper cased.
            var function = new Function();
            var context = new TestLambdaContext();
            var user = new User { firstName = "Test", lastname = "User"};
            var upperCase = function.FunctionHandler(user, context);

            Assert.Equal("Welcome: Test User", upperCase);
        }
    }
}
