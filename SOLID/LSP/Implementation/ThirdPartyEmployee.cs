using SOLID.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Implementation
{
    public class ThirdPartyEmployee : IEmployee
    {
        public int ID { get; set ; }
        public string Name { get; set; }

        public ThirdPartyEmployee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public decimal GetMinSalary()
        {
            return 200;
        }
    }
}
