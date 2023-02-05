using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Decorator
{
    class OnionDecorator : PizzaDecorator
    {

        public OnionDecorator(Pizza pizza) : base(pizza)
        {

        }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}
