using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Pizzas.NYPizzas
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            _name = "NY Style Pepperoni Pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Grated Reggiano Cheese");
            _toppings.Add("Mushrooms");
            _toppings.Add("Onions");
            _toppings.Add("Red Peppers");
            _toppings.Add("Pepperoni");
        }
    }
}
