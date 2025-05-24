using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Interfaz para generar reportes a partir de datos en formato específico.
namespace PracticaPrincipiosSOLID.Reports
{
    public interface IReportGenerator
    {
        string Generate(List<string> data);
    }
}
