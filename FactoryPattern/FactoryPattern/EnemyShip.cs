using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class EnemyShip
    {
        private double _amountDamage;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double AmountDamage
        {
            get { return _amountDamage; }
            set { _amountDamage = value; }
        }

        public void FollowHeroShip()
        {
            Console.WriteLine(_name + " is following the hero.");
        }

        public void DisplayEnemyShip()
        {
            Console.WriteLine(_name + " is on the screen.");
        }

        public void Shoot()
        {
            Console.WriteLine(_name + " attacks and does " + _amountDamage + " damage to hero.");
        }
    }
}
