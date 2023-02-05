using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Composite
{
    class FileComponent : FileSystemComponent
    {
        public FileComponent(string fileName) : base(fileName)
        {

        }
    }
}
