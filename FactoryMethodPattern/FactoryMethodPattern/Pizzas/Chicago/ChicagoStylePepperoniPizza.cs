﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Pizzas.Chicago
{
    class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            _name = "Chicago Style Pepperoni Pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";
            
            _toppings.Add("Shredded Mozzarella Cheese");
            _toppings.Add("Parmesan");
            _toppings.Add("Eggplant");
            _toppings.Add("Black Olives");
            _toppings.Add("Spinach");
            _toppings.Add("Pepperoni");
        }

        public override void Cut() { Console.WriteLine("Cutting the pizza into square slices."); }
    }
}
