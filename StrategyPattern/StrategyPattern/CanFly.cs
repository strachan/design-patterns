﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CanFly : IFlys
    {
        public string Fly()
        {
            return "Flying high!";
        }
    }
}
