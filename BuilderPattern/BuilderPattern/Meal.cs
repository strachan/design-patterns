using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public Meal() { }

        public float GetCost()
        {
            var cost = 0.0f;

            foreach (var item in items)
            {
                cost += item.Price;
            }

            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.Write("Item: " + item.Name);
                Console.Write(", Packing: " + item.Packing.Pack);
                Console.WriteLine(", Price: " + item.Price);
            }
        }

        public void AddItem(IItem item)
        {
            items.Add(item);
        }
    }
}
