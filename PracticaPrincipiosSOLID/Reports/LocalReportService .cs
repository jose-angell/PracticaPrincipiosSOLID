using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Esta implementacion concreta esta hecha para mostrar que cumple con el principio de sustitucion de Liskov
// por que la interfaz solo pide que se implemente RunReport, pero no espcifica que implementa

// Si S es una subClase (o impleentacion) de T, entonces lo sobjetos de tipo T pueden ser reemplazados por 
// objetos de tipo S sin alterar el comportamiento correcto del programa.

// No se rompe ninguna expectativa del cliente: quien llama RunReport(...) sabe que se ejecutara el flujo 
// commpleto segun laimplementacion concreta.
// No lanza excepciones innecesarias, ni viola el contrato de entrada/salida
namespace PracticaPrincipiosSOLID.Reports
{
    public class LocalReportService : IReportService
    {
        private readonly IReportGenerator _generator;
        private readonly IReportSaver _saver;
        public LocalReportService(IReportGenerator generator, IReportSaver saver) 
        {
            _generator = generator;
            _saver = saver;
        }
        public void RunReport(List<string> data)
        {
            if (data == null || data.Count == 0)
            {
                Console.WriteLine("No data to generate report.");
                return;
            }
            var content = _generator.Generate(data);
            _saver.Save(content);
        }

    }
}
