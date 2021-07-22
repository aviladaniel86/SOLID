using SOLID.LSP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Implementation
{
    public class TemporaryEmployee : LSPEmployee
    {
        public TemporaryEmployee(int id, string name) : base(id, name) { }

        public override decimal GetBonus(decimal salary)
        {
            return salary * .05M;
        }

        public override decimal GetMinSalary()
        {
            return 500;
        }
    }
}
