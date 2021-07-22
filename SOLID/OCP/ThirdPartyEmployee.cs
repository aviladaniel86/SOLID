using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class ThirdPartyEmployee : Employee
    {
        public ThirdPartyEmployee(int id, string name) : base(id, name)
        {
        }

        public override void PrintBonus(decimal salary)
        {
            var bonus = salary * .05M;
            Console.WriteLine($"The bonus for the ThirdParty employee is {bonus}");
        }
    }
}
