using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Genera el contenido del reporte para el formato pdf
namespace PracticaPrincipiosSOLID.Reports
{
    public class PdfReportGenerator : IReportGenerator
    {
        public PdfReportGenerator() { }
        public string Generate(List<string> data)
        {
            var contentReport = "";
            foreach (var item in data)
            {
                contentReport += item;
            }
            return contentReport;
        }
    }
}
