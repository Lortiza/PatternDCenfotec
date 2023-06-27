using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI
{
    public class PdfReport : ReportTemplate
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data...");
        }

        protected override void FormatReport()
        {
            Console.WriteLine("Formatting Pdf report...");
        }
    }
}
