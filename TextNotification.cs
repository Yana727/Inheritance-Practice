using System; 

namespace Inheritance_Practice
{
    public class TextNotification : Notification
    {
     public string Recipient {get; set;}
     public string SmsProvider {get; set;}

     public TextNotification (string Recipient, string SmsProvider, string subject, string body): base(subject, body)
     {
         this.Recipient = Recipient;
         this.SmsProvider = SmsProvider; 
     }
     
      public override void Transport()
      {
       Console.WriteLine($"Hello, {Recipient}, {body}. This messge is from {SmsProvider}. The subjext is {Subject}"); 
      
     }
    }
}