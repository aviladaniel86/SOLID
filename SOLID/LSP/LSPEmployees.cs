using SOLID.LSP.Abstract;
using SOLID.LSP.Implementation;
using SOLID.LSP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class LSPEmployees
    {
        public void CallEmployeeBonus()
        {
            List<LSPEmployee> employees = new List<LSPEmployee>();
            employees.Add(new PermanentEmployee(1, "Luis"));
            employees.Add(new TemporaryEmployee(2, "Pablo"));
            //Below cannot be added because its employee type is not elegible for bonus
            //employees.Add(new ThirdPartyEmployee(2, "Jose"));
            foreach (var employee in employees)
            {
                employee.GetBonus(employee.GetMinSalary());
            }

            List<IEmployee> iEmployees = new List<IEmployee>();
            iEmployees.Add(new PermanentEmployee(1, "Luis"));
            iEmployees.Add(new TemporaryEmployee(2, "Pablo"));
            iEmployees.Add(new ThirdPartyEmployee(2, "Jose"));
            foreach (var iEmployee in iEmployees)
            {
                iEmployee.GetMinSalary();
            }
        }
    }
}
