using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.AbstractFactory
{
    internal class VintageFactory : FurnitureFactory
    {
        public override Chair CreateChair()
        {
            return new VintageChair();
        }

        public override Sofa CreateSofa()
        {
            return new VintageSofa();
        }
    }
}
