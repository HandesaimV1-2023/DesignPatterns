using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Decorator
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        //the decorator will always get the object which it needs to decorate
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
    }
}
