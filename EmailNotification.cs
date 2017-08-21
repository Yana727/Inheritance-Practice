using System;

namespace Inheritance_Practice
{
    public class EmailNotification : Notification
    {
        public string Recipient { get; set; }

        public string SmtpProvider { get; set; }

        public EmailNotification(string recipient, string SmsProvider, string body, string subject) :
        base(body, subject)
        {
            this.Recipient = recipient;    //why not using "this"?
            this.SmtpProvider = SmsProvider;
        }
        public override void Transport()
        {
            Console.WriteLine($"The message is from {this.Recipient} on a {SmtpProvider} line. Subject is { Subject} and the message is {Body}");
        }
    }
}
