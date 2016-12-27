using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Pepsi : ColdDrink
    {
        public override string Name
        {
            get
            {
                return "Pepsi";
            }
        }

        public override float Price
        {
            get
            {
                return 35.0f;
            }
        }
    }
}
