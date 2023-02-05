using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Facade
{
    //דוחות שנתיים
    class RetroReport : TaxAuthorityService
    {
        public override string GetService()
        {
            return $"{nameof(RetroReport)} service";
        }
    }
}
