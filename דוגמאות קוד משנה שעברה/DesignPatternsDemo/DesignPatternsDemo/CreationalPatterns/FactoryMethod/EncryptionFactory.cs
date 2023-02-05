using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    class EncryptionFactory
    {
        private static EncryptionFactory factory;
        
        private EncryptionFactory()
        {

        }

        public static EncryptionFactory GetInstance()
        {
            if (factory == null)
            {
                factory = new EncryptionFactory();
            }
            return factory;
        }

        public Encryption CreateEncryption(string key)
        {
            if (key == "Des")
            {
                return new DESEncryption();
            }
            if (key == "RSA")
            {
                return new RSAEncryption();
            }
            throw new Exception("invalid encryption");
        }
    }
}
