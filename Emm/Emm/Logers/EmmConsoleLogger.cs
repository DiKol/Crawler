using System;

namespace Emm.Filters
{
    public class EmmConsoleLogger : IEmmLogger
    {
        public void Log(string message)
        {

            Console.WriteLine(message);
        }
    }
}
