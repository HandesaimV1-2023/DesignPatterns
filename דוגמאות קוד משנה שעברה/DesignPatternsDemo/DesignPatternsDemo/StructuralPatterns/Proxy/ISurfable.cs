using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Structural
{
    internal interface ISurfable
    {
        //imagine the returned string is actually a whole web page
        public string Surf(string url);
    }
}
