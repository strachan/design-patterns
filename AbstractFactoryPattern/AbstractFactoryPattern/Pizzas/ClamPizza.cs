using AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Pizzas
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory = null;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
            _clams = _ingredientFactory.CreateClams();
        }
    }
}
