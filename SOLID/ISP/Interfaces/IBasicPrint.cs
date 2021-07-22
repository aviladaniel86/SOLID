using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    public interface IBasicPrint
    {
        bool Print(string content);
        bool Scan(string content);
        bool Copy(string content);
    }
}
