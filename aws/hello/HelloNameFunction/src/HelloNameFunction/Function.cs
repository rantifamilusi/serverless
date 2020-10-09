using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using HelloNameFunction.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace HelloNameFunction
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(User input, ILambdaContext context)
        {
            if (input is null)
            {
                 LambdaLogger.Log($"A user don't exists :  {context.FunctionName}\\n");
                throw new ArgumentNullException(nameof(input));
            }

            LambdaLogger.Log($"Calling function name: {context.FunctionName}\\n");
            return $"Welcome: {input?.firstName} {input?.lastname}";
        }
    }
}
