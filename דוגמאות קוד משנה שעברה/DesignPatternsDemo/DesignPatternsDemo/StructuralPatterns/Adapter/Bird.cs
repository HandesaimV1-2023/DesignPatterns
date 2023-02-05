using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Adapter
{
    class Bird : Animal
    {
        public override string Play()
        {
            return "tzif tzif";
        }
    }
}
