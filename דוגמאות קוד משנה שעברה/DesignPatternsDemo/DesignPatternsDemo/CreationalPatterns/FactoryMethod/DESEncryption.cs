using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    class DESEncryption : Encryption
    {
        public override Stream Dencrypt(Stream stream)
        {
            throw new NotImplementedException();
        }

        public override Stream Encrypt(Stream stream)
        {
            throw new NotImplementedException();
        }
    }
}
