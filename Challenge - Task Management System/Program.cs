using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Challenge___Task_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailTask = new EmailTask()
            {
                Message = "Hello, this is a test email.",
                Recipient = "example@example.com"
            };

            var reportTask = new ReportTask()
            {
                ReportName = "Annual Report"
            };

            var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute());

            Console.ReadKey();
        }
    }
}
