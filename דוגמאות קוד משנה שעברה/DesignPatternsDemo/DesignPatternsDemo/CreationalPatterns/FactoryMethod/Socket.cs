using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    class Socket
    {
        public Socket(string howtoEncrypt)
        {
            EncryptionFactory factory = EncryptionFactory.GetInstance();
            Encryption enc = factory.CreateEncryption(howtoEncrypt);
            //enc.Encrypt(InputStream);
            //...
        }
        public Stream InputStream { get; set; }
        public Stream OuputStream { get; set; }
    }

    class Stream { }

    class RSAStream : Stream { }
    class DESStream : Stream { }
}
