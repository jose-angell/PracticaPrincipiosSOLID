using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// clase para la implementacion se un  proceso completo de el reporte
namespace PracticaPrincipiosSOLID.Reports
{
    public class ReportService: IReportService
    {
        // ReportService depende de abstracciones (IReportGenerator,etc) no de implementaciones,
        // Concretas como PdfReportGenerator. Eso permite cambiar comportameinto si modificar la clase.
        // permitienedo que se pueda usar cualquier tipo de reporte, o metodo de envio o de guardado
        private readonly IReportGenerator _generator;
        private readonly IReportSaver _saver;
        private readonly IReportSender _sender;
        public ReportService(IReportGenerator generator,IReportSaver saver, IReportSender sender) 
        {
            // inyeccion de dependencias, al momento de implementear esta clase el que la usa
            // debe entregarle las implementaciones concretas de lo que estara usando para generar el reporte
            // guardarlo y enviarlo.
            _generator = generator;
            _saver = saver;
            _sender = sender;
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
            _sender.Send(content);
        }
    }
}
