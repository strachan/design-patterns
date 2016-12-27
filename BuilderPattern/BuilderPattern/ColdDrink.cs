using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name { get; }

        public IPacking Packing
        {
            get
            {
                return new Bottle();
            }
        }

        public abstract float Price { get; }
    }
}
