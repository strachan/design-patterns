using AbstractFactoryPattern.Ingredients.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Pizza
    {
        protected string _name;
        protected IDough _dough;
        protected ISauce _sauce;
        protected IPepperoni _pepperoni;
        protected IClams _clams;
        protected List<IVeggie> _veggies;
        protected ICheese _cheese;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //public override string ToString() { }

        public abstract void Prepare();

        public virtual void Bake() { Console.WriteLine("Bake for 25 minutes at 350."); }

        public virtual void Cut() { Console.WriteLine("Cutting the pizza into diagonal slices."); }

        public virtual void Box() { Console.WriteLine("Place pizza in official PizzaStore box."); }
    }
}
