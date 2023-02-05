using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Composite
{
    class FolderComponent : FileSystemComponent
    {
        List<FileSystemComponent> components;

        public FolderComponent(string folderName) : base(folderName)
        {
            components = new List<FileSystemComponent>();
        }

        public void AddComponent(FileSystemComponent component)
        {
            //check tthat component with same name does not exits....
            components.Add(component);
        }

        public void RemoveComponent(FileSystemComponent component)
        {
            //check that the componnet to remove is not int use...
            var comp = components.FirstOrDefault(c => c.Name == component.Name);
            components.Remove(comp);
        }

        public override string ShowDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            if (components.Count > 0)
            {
                sb.AppendLine("the files in the folder as follow");
                foreach (var item in components)
                {
                    sb.AppendLine(item.ShowDetails());
                }
            }
            else
            {
                sb.AppendLine("the folder is empty");
            }
            return sb.ToString();
        }
    }
}
