using AbstractFactoryPattern.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PizzaStoreFactory
    {
        public static PizzaStore MakePizzaStore(string pizzaStyle)
        {
            PizzaStore pizzaStore = null;

            if (pizzaStyle.Equals("C")) pizzaStore = new ChicagoPizzaStore();
            else if (pizzaStyle.Equals("N")) pizzaStore = new NYPizzaStore();

            return pizzaStore;
        }
    }
}
