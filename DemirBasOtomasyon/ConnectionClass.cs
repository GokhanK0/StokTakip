using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemirBasOtomasyon
{
    class ConnectionClass
    {
        public string address = System.IO.File.ReadAllText(@"D:\localDB1.txt");
    }
}
