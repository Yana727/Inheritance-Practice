using System;

namespace Inheritance_Practice
{
    public abstract class Notification
    {
        public DateTime createdAt { get; set; } = DateTime.Now;
        public string Subject { get; set; }
        public string Body { get; set; }

        public Notification(string body, string subject)
        {
            this.Subject = subject;
            this.Body = body;
        }

        public abstract void Transport();//Why are we not using the "throw?" 
    }
}
