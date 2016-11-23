using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What style of pizza do you want? New York Style (n) or Chicago Style (c)");
                var pizzaStyleChosen = Console.ReadKey().Key.ToString();
                Console.WriteLine();
                Console.WriteLine("What pizza do you want? Cheese (c), Veggie (v), Pepperoni (p) or Clams (f)");
                var pizzaChosen = Console.ReadKey().Key.ToString();
                Console.WriteLine();

                PizzaStore pizzaStore = PizzaStoreFactory.MakePizzaStore(pizzaStyleChosen);
                if (pizzaStore == null)
                {
                    Console.WriteLine("Choose the right style!");
                    continue;
                }
                if (pizzaChosen.Equals("C") || pizzaChosen.Equals("V") || pizzaChosen.Equals("P") || pizzaChosen.Equals("F"))
                {
                    string pizzaFlavour = pizzaChosen.Equals("C") ? "cheese" : pizzaChosen.Equals("V") ? "veggie" : pizzaChosen.Equals("P") ? "pepperoni" : "clams";
                    pizzaStore.OrderPizza(pizzaFlavour);
                }
                else
                {
                    Console.WriteLine("Choose the right pizza!");
                    continue;
                }
                Console.WriteLine();
            }
        }
    }
}
