using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chocolate = new Chocolate();

            Console.WriteLine("Instance ID: " + chocolate.GetHashCode());

            var chocolate2 = new Chocolate();

            Console.WriteLine("Instance ID: " + chocolate2.GetHashCode());

            var chocolateBoiler = ChocolateBoiler.GetInstance();

            Console.WriteLine("Instance ID: " + chocolateBoiler.GetHashCode());

            var chocolateBoiler2 = ChocolateBoiler.GetInstance();

            Console.WriteLine("Instance ID: " + chocolateBoiler2.GetHashCode());

            Console.ReadKey();
        }
    }
}
