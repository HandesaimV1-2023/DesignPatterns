using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class Address
    {
        public AddressType Type { get; private set; }
        //country...
        //city

        public Address(string address)
        {
            if (address.Length < 10)
            {
                Type = AddressType.InsideCountry;
            }
            else if (address.Length > 10 && address.Length < 20)
            {
                Type = AddressType.Abroad;
            }
            else
            {
                Type = AddressType.OffPlanet;
            }
        }
    }
}
