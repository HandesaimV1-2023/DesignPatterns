using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Decorator
{
    class GlutenFreePizza : Pizza
    {
        public override int GetCost()
        {
            return 15;
        }
    }
}
