using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Decorator
{
    class Margarita : Pizza
    {
        public override int GetCost()
        {
            return 10;
        }
    }
}
