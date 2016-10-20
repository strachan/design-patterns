using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CanNotFly : IFlys
    {
        public string Fly()
        {
            return "I can't fly!";
        }
    }
}
