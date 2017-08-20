namespace Inheritance_Practice
{
    public class EmailNotification : Notifications
    {
        public string Recipient { get; set; }
        public string SmtpProvider { get; set; }
       
        public  EmailNotification(string Recipient, string SmsProvider, string body, string subject): 
        base(body, subject)
        {
            this.Recipient = Recipient;    //why not using "this"?
            this.SmtpProvider = SmsProvider;
        }
    public override void Transport()
    {
        Console.WriteLine($"The message is from {Recipient} on a {SmtpProvider} line. Subject is { Subject} and the message is {body}");
    }
} 
} 
