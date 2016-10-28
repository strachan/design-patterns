using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            AmountDamage = 10.0;
            Name = "Rocket Enemy Ship";
        }
    }
}
