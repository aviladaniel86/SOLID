using SOLID.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Abstract
{
    public abstract class LSPEmployee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get ; set ; }

        public LSPEmployee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public abstract decimal GetBonus(decimal salary);

        public abstract decimal GetMinSalary();
    }
}
