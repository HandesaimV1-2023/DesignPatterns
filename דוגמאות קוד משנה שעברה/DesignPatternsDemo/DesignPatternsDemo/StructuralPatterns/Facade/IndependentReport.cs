using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Facade
{
    //דוחות לעצמאיים
    class IndependentReport : TaxAuthorityService
    {
        public override string GetService()
        {
            return $"{nameof(IndependentReport)} service";
        }
    }
}
