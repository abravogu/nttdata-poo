using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProyect.Inheritance
{
    public class NttDataBase
    {
        public Guid Guid;


        public Guid Gid()
        {
            return Guid;
        }


        public NttDataBase()
        {
            this.Guid = Guid.NewGuid();
        }
    }
}
