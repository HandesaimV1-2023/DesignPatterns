using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    abstract class MailItem
    {
        public Address MailAddress { get; set; }

        public MailItem(Address address)
        {
            MailAddress = address;
        }

        public abstract int Send();
    }
}
