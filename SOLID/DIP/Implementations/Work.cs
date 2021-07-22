using SOLID.DIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.Implementations
{
    public class Work : IWork
    {
        ILogger _logger;
        public string WorkName { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }

        public IPerson Owner { get; set; }

        public Work(ILogger logger)
        {
            _logger = logger;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.LogMessage($"{Owner.Name} worked { WorkName } hours");
        }

        public void CompleteWork()
        {
            IsComplete = true;

            _logger.LogMessage($"Work completed { WorkName }");
        }
    }
}
