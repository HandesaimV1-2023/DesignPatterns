using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.StructuralPatterns.Facade
{
    class TaxAuthorityFacade
    {
        public TaxAuthorityService GetRefundService()
        {
            return new Refund();
        }

        public TaxAuthorityService GetIndependentReport()
        {
            return new IndependentReport();
        }

        public TaxAuthorityService GetRetroReport()
        {
            return new RetroReport();
        }
    }
}
