using SOLID.LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Implementation
{
    public class PermanentEmployee : LSPEmployee
    {
        public PermanentEmployee(int id, string name) : base (id, name) { }

        public override decimal GetBonus(decimal salary)
        {
            return salary * .1M;
        }

        public override decimal GetMinSalary()
        {
            return 1000;
        }
    }
}
