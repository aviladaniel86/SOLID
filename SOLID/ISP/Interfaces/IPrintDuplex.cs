using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    interface IPrintDuplex
    {
        bool PrintDuplex(string content);
    }
}
