using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// interfaz para determinar el comportamiento del servicio que orqueta el proceso del reporte
namespace PracticaPrincipiosSOLID.Reports
{
    public interface IReportService
    {
        void RunReport(List<string> data);
    }
}
