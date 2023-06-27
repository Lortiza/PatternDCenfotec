using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI
{
    public abstract class ReportTemplate
    {
        public void GenerateReport()
        {
            CollectData();
            FormatReport();
            DisplayReport();
        }

        // Abstract methods to be implemented by subclasses
        protected abstract void CollectData();
        protected abstract void FormatReport();

        // Default implementation of displaying the report
        protected virtual void DisplayReport()
        {
            Console.WriteLine("Displaying the product report...");
        }
    }
}
