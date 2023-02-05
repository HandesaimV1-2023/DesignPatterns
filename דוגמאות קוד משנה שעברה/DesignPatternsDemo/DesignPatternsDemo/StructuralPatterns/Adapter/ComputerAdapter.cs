using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Adapter
{
    //this is the adapter!!!
    class ComputerAdapter : IPlayable
    {
        Computer computer;
        public ComputerAdapter(Computer computer)
        {
            this.computer = computer;
        }
        public string Play()
        {
            //this is the service method
            return computer.Beep();
        }
    }
}
