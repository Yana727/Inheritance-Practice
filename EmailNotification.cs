namespace Inheritance_Practice
{
    public class EmailNotification : Notifications
    {
        public string Recipient { get; set; }
        public string SmsProvider { get; set; }
       
        public  EmailNotifications(string Recipient, string SmsProvider, string body, string subject): 
        base(body, subject)
        {
            this.Recipient = Recipient;    //why not using "this"?
            this.SmsProvider = SmsProvider;
        }
    public override void Transport()
    {
        Console.WriteLine($"The message is from {Recipient} on a {SmsProvider} line. Subject is { Subject} and the message is {body}");
    }
} 
} 
