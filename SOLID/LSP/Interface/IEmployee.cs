using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Interface
{
    public interface IEmployee
    {
        int ID { get; set; }
        String Name { get; set; }

        decimal GetMinSalary();
    }
}
