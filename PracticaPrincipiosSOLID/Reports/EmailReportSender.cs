using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Implementacion concreta de la interfaz IReprotSender
namespace PracticaPrincipiosSOLID.Reports
{
    public class EmailReportSender: IReportSender
    {
        public EmailReportSender() { }
        public void Send(string report)
        {
            Console.WriteLine("Sending report to email...");
            Console.WriteLine($"Report content (preview): {report.Substring(0, Math.Min(report.Length, 100))}...");
        }
    }
}
