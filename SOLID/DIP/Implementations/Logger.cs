using SOLID.DIP.Interfaces;
using System;

namespace SOLID.DIP.Implementations
{
    public class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"This is the message to log: { message }");
        }
    }
}
