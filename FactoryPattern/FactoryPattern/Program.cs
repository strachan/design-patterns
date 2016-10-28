using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the factory object
            EnemyShipFactory shipFactory = new EnemyShipFactory();

            // Enemy ship object
            EnemyShip enemyShip = null;

            while (true) {

                Console.WriteLine("What type of ship? (U / R / B)");
                var keyPressed = Console.ReadKey().Key.ToString();
                Console.WriteLine();

                enemyShip = shipFactory.MakeEnemyShip(keyPressed);

                if (enemyShip != null)
                {
                    doEnemyStuff(enemyShip);
                }
                else
                {
                    Console.WriteLine("Please enter U, R, or B.");
                }
            }
        }

        private static void doEnemyStuff(EnemyShip enemyShip)
        {
            enemyShip.DisplayEnemyShip();
            enemyShip.FollowHeroShip();
            enemyShip.Shoot();
        }
    }
}
