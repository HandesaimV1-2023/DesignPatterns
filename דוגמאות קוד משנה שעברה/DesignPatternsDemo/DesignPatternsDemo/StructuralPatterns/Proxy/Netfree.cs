using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Structural
{
    internal class Netfree : ISurfable
    {
        List<string> blackList;

        OpenInternet openInternet;

        public Netfree(OpenInternet internet)
        {
            openInternet = internet;
            blackList = new List<string>() { "facebook", "twitter", "instagram" };
        }

        public bool CheckAccess(string url)
        {
            return blackList.Contains(url);
        }

        public string Surf(string url)
        {
            if (CheckAccess(url))
            {
                return "Watch yourself!!! don't go to this web page";
            }
            return openInternet.Surf(url);
        }
    }
}
