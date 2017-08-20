namespace Inheritance_Practice
{
    public abstract class Notifications
    {
        public DateTime createdAt { get; set; } = DateTime.Now;
        public string Subject { get; set; }
        public string Body { get; set; }

        public Notifications(string body, string subject)
        {
            this.createdAt = DateTime.now();
            this.Subject = subject;
            this.Body = body;
        }

            public abstract void Transport();
    
        }
    }