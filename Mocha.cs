using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentationWithEnum
{
    public class Mocha : CondimentDecorator
    {
        Beverage Beverage;

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return 0.2 + Beverage.Cost();
        }
    }
}
