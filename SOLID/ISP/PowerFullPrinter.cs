using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public class PowerFullPrinter : FaxPrinter, IPrintDuplex
    {
        public bool PrintDuplex(string content)
        {
            Console.WriteLine("duplex print");
            return true;
        }
    }
}
