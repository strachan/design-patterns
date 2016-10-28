using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(string newShipType)
        {
            EnemyShip newEnemyShip = null;

            if (newShipType == "U") { newEnemyShip = new UfoEnemyShip(); }
            if (newShipType == "R") { newEnemyShip = new RocketEnemyShip(); } 
            if (newShipType == "B") { newEnemyShip = new BigUfoEnemyShip(); }

            return newEnemyShip;
        }
    }
}
