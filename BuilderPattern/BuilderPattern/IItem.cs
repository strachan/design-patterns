using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IItem
    {
        string Name { get; }
        IPacking Packing { get; }
        float Price { get; }
    }
}
