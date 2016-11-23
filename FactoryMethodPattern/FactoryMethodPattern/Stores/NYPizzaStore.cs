using FactoryMethodPattern.Pizzas.NYPizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore() { }

        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese")) { return new NYStyleCheesePizza(); }
            else if (type.Equals("veggie")) { return new NYStyleVeggiePizza(); }
            else if (type.Equals("pepperoni")) { return new NYStylePepperoniPizza(); }
            else { return null; }
        }
    }
}
