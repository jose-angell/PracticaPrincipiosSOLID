using PracticaPrincipiosSOLID.Reports;

var data = new List<string> { "Item 1", "Item 2", "Item 3" };

IReportGenerator generator = new PdfReportGenerator();
IReportSaver saver = new DiskReportSaver();
IReportSender sender = new EmailReportSender();

// para poder implemnetar el reporte service se deben entregar las dependencias que se piensan usar
// en este caso para generar el reporte es el de pdf, para enviarlo el de emeail, y para guardarlo el de Disk
var reportService = new ReportService(generator, saver, sender);
reportService.RunReport(data);