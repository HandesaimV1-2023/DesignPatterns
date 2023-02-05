using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.Builder
{
    internal class MasterCardReportBuilder : ReportBuilder
    {
        public MasterCardReportBuilder()
        {
            report = "<MasterCardEntries>\n";
        }

        public override void AddEntry(string cardNumber, int amount)
        {
            report += $"<Entry>\n<CardNumber>{cardNumber}</CardNumber>\n<Amount>{amount}</Amount>\n</Entry>\n";
        }

        public override string GetReport()
        {
            report += "</MasterCardEntries>";
            return report;
        }
    }
}
