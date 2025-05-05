using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_10_TM.Tools
{
    internal class Class1
    {
        public string ClassparamPostgreSQL ()
        { string result = string.Empty;
          result = "Host=localhost;Port=5432;Username=postgres;Password=wily;Database=PBOTM;Pooling=true";
            return result;
        }
    }
}
