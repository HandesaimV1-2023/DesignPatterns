using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo
{
    interface IFIleManager
    {
        FileInFolder Search(string description);
        void CleanFiles();

    }
}
