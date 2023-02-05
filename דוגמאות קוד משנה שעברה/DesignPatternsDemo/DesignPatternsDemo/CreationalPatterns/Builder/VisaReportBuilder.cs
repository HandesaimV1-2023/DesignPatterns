using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.Builder
{
    internal class VisaReportBuilder : ReportBuilder
    {
        public VisaReportBuilder()
        {
            report = "-----------Visa Report------------\n";
            report += $"Card Number\t\t\tAmount\n";
        }

        public override void AddEntry(string cardNumber, int amount)
        {
            report += $"{cardNumber}\t\t\t{amount}\n";
        }

        public override string GetReport()
        {
            return report;
        }
    }
}
