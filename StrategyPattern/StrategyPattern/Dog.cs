using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Dog : Animal
    {
        public Dog()
        {
            flyingType = new CanNotFly();
        }
    }
}
