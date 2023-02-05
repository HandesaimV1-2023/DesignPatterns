using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternsDemo
{
    class Drive
    {
        public List<Folder> Folders { get; set; }
    }

    class Folder
    {
        public List<FileInFolder> Files { get; set; }
    }

    class FileInFolder
    {
        public string Name { get; set; }
        public string Extension { get; set; }
    }
}
