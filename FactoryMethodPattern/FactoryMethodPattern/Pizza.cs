using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        protected string _name;
        protected string _dough;
        protected string _sauce;
        protected List<string> _toppings = new List<string>();

        public string Name { get { return _name; } }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding topics: ");
            foreach (string topping in _toppings)
            {
                Console.WriteLine("    " + topping);
            }
        }

        public virtual void Bake() { Console.WriteLine("Bake for 25 minutes at 350."); }

        public virtual void Cut() { Console.WriteLine("Cutting the pizza into diagonal slices."); }

        public virtual void Box() { Console.WriteLine("Place pizza in official PizzaStore box."); }
    }
}
