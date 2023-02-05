using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Adapter
{
    abstract class Animal : IPlayable
    {
        public string Name { get; set; }

        public abstract string Play();        

        //public abstract string MakeSound();


    }
}
