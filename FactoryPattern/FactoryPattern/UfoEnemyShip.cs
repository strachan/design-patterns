using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class UfoEnemyShip : EnemyShip
    {
        public UfoEnemyShip()
        {
            AmountDamage = 20.0;
            Name = "Ufo Enemy Ship";
        }
    }
}
