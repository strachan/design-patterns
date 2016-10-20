using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Animal
    {
        protected IFlys flyingType;

        public string TryToFly()
        {
            return flyingType.Fly();
        }

        public void SetFlyingBehaviour(IFlys newFlyingType)
        {
            flyingType = newFlyingType;
        }
    }
}
