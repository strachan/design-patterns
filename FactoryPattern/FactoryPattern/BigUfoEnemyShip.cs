using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BigUfoEnemyShip : EnemyShip
    {
        public BigUfoEnemyShip()
        {
            AmountDamage = 40.0;
            Name = "Big Ufo Enemy Ship";
        }
    }
}
