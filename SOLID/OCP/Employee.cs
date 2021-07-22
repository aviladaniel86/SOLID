using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public abstract void PrintBonus(decimal salary);
    }
}
