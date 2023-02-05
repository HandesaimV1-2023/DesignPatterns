using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Facade
{
    //שירות כלשהו של רשות המיסים
    abstract class TaxAuthorityService
    {
        //public virtual string GetService()
        //{
        //    return "no service";
        //}
        public abstract string GetService();
    }
}
