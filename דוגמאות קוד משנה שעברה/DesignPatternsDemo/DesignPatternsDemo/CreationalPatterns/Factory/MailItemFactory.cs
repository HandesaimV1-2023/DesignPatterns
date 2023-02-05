using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    class MailItemFactory
    {
        public MailItem Create(string addressStr)
        {
            Address address = new Address(addressStr);
            switch (address.Type)
            {
                case AddressType.InsideCountry:
                    return new TruckMail(address);
                case AddressType.Abroad:
                    return new AirplaneMail(address);
                case AddressType.OffPlanet:
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
