using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class TruckMail : MailItem
    {
        public TruckMail(Address address) : base(address)
        {

        }
        public override int Send()
        {
            //....
            //put the truck mail item on th truck...
            return 2;
        }
    }
}
