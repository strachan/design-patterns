using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class VegBurger : Burger
    {
        public override string Name
        {
            get
            {
                return "Veg Burger";
            }
        }

        public override float Price
        {
            get
            {
                return 25.0f;
            }
        }
    }
}
