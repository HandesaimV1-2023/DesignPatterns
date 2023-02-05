using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class MySingleton
    {
        static MySingleton instance;


        private MySingleton()
        {

        }

        public static MySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    object key = new object();
                    lock (key)
                    {
                        if (instance == null)
                        {
                            instance = new MySingleton();
                        }
                    }
                }
                return instance;
            }
        }
        //        public getInstance
    }

    internal class Person
    {

        public void DoWork()
        {
            lock (this)
            {

            }
        }
    }
}
