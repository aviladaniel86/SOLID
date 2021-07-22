using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class BasicPrinter : IBasicPrint
    {
        public bool Copy(string content)
        {
            Console.WriteLine("copy");
            return true;
        }

        public bool Print(string content)
        {
            Console.WriteLine("print");
            return true;
        }

        public bool Scan(string content)
        {
            Console.WriteLine("scan");
            return true;
        }
    }
}
