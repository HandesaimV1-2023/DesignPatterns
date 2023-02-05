using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Composite
{
    class FileSystemComponent
    {
        public string Name { get; set; }

        public FileSystemComponent(string name)
        {
            Name = name;
        }

        public virtual string ShowDetails()
        {
            return Name;
        }
    }
}
