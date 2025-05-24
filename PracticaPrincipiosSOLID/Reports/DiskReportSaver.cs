using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Guarda un reporte como un archivo local en disco.
namespace PracticaPrincipiosSOLID.Reports
{
    public class DiskReportSaver : IReportSaver
    {
        public DiskReportSaver() { }
        public void Save(string content)
        {
            Console.WriteLine("Saving report to disk...");
        }
    }
}
