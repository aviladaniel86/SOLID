using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class InternalEmployee : Employee
    {
        public InternalEmployee(int id, string name) : base(id, name)
        {
        }

        public override void PrintBonus(decimal salary)
        {
            var bonus = salary * .1M;
            Console.WriteLine($"The bonus for the Internal employee is {bonus}");
        }
    }
}
