using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    // We must ensure high level functionality is not coupled to low level functionality

    internal class Program
    {
        static void Main(string[] args)
        {
            IEmailService emailService = new MockEmailService();
            Notification notification = new Notification(emailService);
            notification.Send("Hello, this is a test notification");
        }
    }

    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }

    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email to {to} with subject {subject}");
        }
    }

    public class Notification
    {
        private readonly IEmailService _emailService;

        public Notification(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Send(string message)
        {
            _emailService.SendEmail("user@example.com", "Notification", message);
        }
    }

    public class MockEmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
