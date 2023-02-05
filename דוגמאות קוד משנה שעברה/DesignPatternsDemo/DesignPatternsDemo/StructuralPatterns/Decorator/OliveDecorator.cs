using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Decorator
{
    class OliveDecorator : PizzaDecorator
    {
        public OliveDecorator(Pizza pizza) : base(pizza)
        {

        }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}
