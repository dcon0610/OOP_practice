﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentationWithEnum
{
    public abstract class Beverage
    {
        public string Description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();

        
    }
}
