using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ChickenBurger : Burger
    {
        public override string Name
        {
            get
            {
                return "Chicken Burger";
            }
        }

        public override float Price
        {
            get
            {
                return 50.5f;
            }
        }
    }
}
