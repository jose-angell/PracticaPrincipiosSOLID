using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Define un contrato para enviar un reporte a través de un canal.
namespace PracticaPrincipiosSOLID.Reports
{
    public interface IReportSender
    {
        void Send(string report);
    }
}
