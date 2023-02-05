using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class AirplaneMail : MailItem
    {
        public AirplaneMail(Address addr) : base(addr)
        {

        }

        public override int Send()
        {
            return 7;
        }
    }
}
