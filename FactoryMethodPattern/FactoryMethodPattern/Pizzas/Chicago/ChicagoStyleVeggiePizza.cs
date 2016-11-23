using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Pizzas.Chicago
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            _name = "Chicago Style Veggie Pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";

            _toppings.Add("Shredded Mozzarella Cheese");
            _toppings.Add("Parmesan");
            _toppings.Add("Eggplant");
            _toppings.Add("Black Olives");
            _toppings.Add("Spinach");
        }

        public override void Cut() { Console.WriteLine("Cutting the pizza into square slices."); }
    }
}
