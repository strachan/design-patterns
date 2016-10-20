using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal bolt = new Dog();
            Animal blue = new Bird();

            Console.WriteLine("Dog: " + bolt.TryToFly());
            Console.WriteLine("Bird: " + blue.TryToFly());

            bolt.SetFlyingBehaviour(new CanFly());

            Console.WriteLine("Mutant Dog: " + bolt.TryToFly());
            Console.ReadKey();
        }
    }
}
