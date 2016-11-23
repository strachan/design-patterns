using AbstractFactoryPattern.Ingredients.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();

        ISauce CreateSauce();

        ICheese CreateCheese();

        List<IVeggie> CreateVeggies();

        IPepperoni CreatePepperoni();

        IClams CreateClams();
    }
}
