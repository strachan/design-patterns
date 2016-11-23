using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Ingredients.Intefaces;
using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {

        public NYPizzaIngredientFactory() { }

        public ICheese CreateCheese() { return new ReggianoCheese(); }

        public IClams CreateClams() { return new FreshClams(); }

        public IDough CreateDough() { return new ThinCrustDough(); }

        public IPepperoni CreatePepperoni() { return new SlicedPepperoni(); }

        public ISauce CreateSauce() { return new MarinaraSauce(); }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie> { new Garlic(), new Onion(), new RedPepper(), new Mushroom() };
        }
    }
}
