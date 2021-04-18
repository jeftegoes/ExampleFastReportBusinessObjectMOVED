using System;
using System.Data;
using System.IO;
using FastReport;
using FastReport.Export.PdfSimple;

namespace ExampleFastReportBusinessObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var reportsFolder = "Report/";

            var report = new Report();
            report.Load(Path.Combine(reportsFolder, "PersonsReport.frx"));

            report.RegisterData(new Person().GetPersons(), "Persons");

            report.Prepare();

            var pdfExport = new PDFSimpleExport();

            pdfExport.Export(report, $"PersonsReport_{ DateTime.Now.ToString("HHmmss") }.pdf");
        }
    }
}
