using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Creational.Builder
{

    internal class ATMMachine//automatic machine to produce reports - Director
    {
        //ReportBuilder builder;
        //public ReportBuilder Builder { private get; set; }
        //public ATMMachine()
        //{

        //}
        //public ATMMachine(ReportBuilder builder)
        //{
        //    this.Builder = builder;
        //}

        public string DisplayReport(ReportBuilder builder, string filePath)
        {
            //get the rows from a file....
            ///display them in a report
            //just for the demo - we will create entries with a simple for loop
            for (int i = 0; i < 10; i++)
            {
                builder?.AddEntry($"{i * 10000}", i + 50);
            }
            return builder?.GetReport();
        }
    }

}