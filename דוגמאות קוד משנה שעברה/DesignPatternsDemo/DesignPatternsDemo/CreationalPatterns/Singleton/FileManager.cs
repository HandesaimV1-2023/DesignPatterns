using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    class FileManager : IFIleManager
    {
        private static FileManager instance;
        public List<Drive> Drives { get; set; }

        private FileManager()
        {
            //initialize all the needed properties...
        }

        public static FileManager GetInstance()
        {
            if (instance == null)
            {
                instance = new FileManager();
            }
            return instance;
        }

        public FileInFolder Search(string description)
        {
            //seearch for matching files...
            Console.WriteLine($"searching for {description}");
            return new FileInFolder();
        }

        public void CleanFiles()
        {
            Console.WriteLine($"cleaning files");
        }
    }
}
