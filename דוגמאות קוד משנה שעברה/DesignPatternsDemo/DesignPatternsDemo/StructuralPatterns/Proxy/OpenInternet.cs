using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Structural
{
    internal class OpenInternet : ISurfable
    {
        public string Surf(string url)
        {
            return $"the page in {url} is this....";
        }
    }
}
