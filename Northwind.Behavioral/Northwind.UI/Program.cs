using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Northwind.UI;

var htmlReport = new HtmlReport();
var pdfReport = new PdfReport();

htmlReport.GenerateReport();
pdfReport.GenerateReport();
