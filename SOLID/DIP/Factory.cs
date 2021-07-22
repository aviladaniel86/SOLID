using SOLID.DIP.Implementations;
using SOLID.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    public class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IWork CreateWork()
        {
            return new Work(CreateLogger());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
