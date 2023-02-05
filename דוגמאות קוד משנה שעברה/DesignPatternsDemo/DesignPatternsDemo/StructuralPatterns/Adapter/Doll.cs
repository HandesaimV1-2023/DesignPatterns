using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Adapter
{
    class Doll : IPlayable
    {
        public string Play()
        {
            return "you are the best mommy";
        }
    }
}
