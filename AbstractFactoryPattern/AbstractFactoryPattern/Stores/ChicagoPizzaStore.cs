using AbstractFactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore() {}

        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "Chicago Style Veggie Pizza";
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PeperroniPizza(ingredientFactory);
                pizza.Name = "Chicago Style Pepperoni Pizza";
            }
            else if (type.Equals("clams"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Chicago Style Clam Pizza";
            }

            return pizza;
        }
    }
}
