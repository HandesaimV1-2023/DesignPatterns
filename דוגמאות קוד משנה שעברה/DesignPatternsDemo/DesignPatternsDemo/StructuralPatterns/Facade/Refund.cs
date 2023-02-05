using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Facade
{
    //מחלקת החזרים
    class Refund : TaxAuthorityService
    {
        public override string GetService()
        {
            return $"{nameof(Refund)} service";
        }
    }
}
