﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface Observer
    {
        void Update(double petrPrice, double valePrice, double abevPrice);
    }
}
