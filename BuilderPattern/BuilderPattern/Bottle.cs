using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Bottle : IPacking
    {
        public string Pack
        {
            get
            {
                return "Bottle";
            }
        }
    }
}
