using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    class RSAEncryption : Encryption
    {
        public override Stream Dencrypt(Stream stream)
        {
            //do encryption in RSA method...
            //return the encrypted stream
            return new RSAStream();
        }

        public override Stream Encrypt(Stream stream)
        {
            return new RSAStream();
        }
    }
}
