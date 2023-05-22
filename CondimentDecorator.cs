using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentationWithEnum
{
    public abstract class CondimentDecorator : Beverage // what extra functionality does this class give me? 
    {
        public abstract override string GetDescription();

        public virtual string CondimentAmount(int amount) // so you can implement 
        {
            return "test";
        }
    }
}
