using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.Builder
{

    internal abstract class ReportBuilder
    {
        protected string report;
        public abstract void AddEntry(string cardNumber, int amount);
        public abstract string GetReport();
    }

}