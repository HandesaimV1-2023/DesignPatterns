using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Adapter
{
    //let's imagine we can't touch this class
    class Computer
    {
        public string Beep()
        {
            return "beep beep";
        }
    }
}
