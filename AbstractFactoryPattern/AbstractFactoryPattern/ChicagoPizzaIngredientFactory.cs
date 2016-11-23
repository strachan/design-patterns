using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Ingredients.Intefaces;
using AbstractFactoryPattern.Ingredients;

namespace AbstractFactoryPattern
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ChicagoPizzaIngredientFactory() { }

        public ICheese CreateCheese() { return new MozzarellaCheese(); }

        public IClams CreateClams() { return new FrozenClams(); }

        public IDough CreateDough() { return new ThickCrustDough(); }

        public IPepperoni CreatePepperoni() { return new SlicedPepperoni(); }

        public ISauce CreateSauce() { return new PlumTomatoSauce(); }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie> { new BlackOlives(), new EggPlant(), new Spinach() };
        }
    }
}
