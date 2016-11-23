using AbstractFactoryPattern;
using AbstractFactoryPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore() { }

        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "New York Style Veggie Pizza";
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PeperroniPizza(ingredientFactory);
                pizza.Name = "New York Style Pepperoni Pizza";
            }
            else if (type.Equals("clams"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "New York Style Clam Pizza";
            }

            return pizza;
        }
    }
}
