using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.CreationalPatterns.FactoryMethod
{
    abstract class Encryption
    {
        public abstract Stream Encrypt(Stream stream);
        public abstract Stream Dencrypt(Stream stream);

    }
}
