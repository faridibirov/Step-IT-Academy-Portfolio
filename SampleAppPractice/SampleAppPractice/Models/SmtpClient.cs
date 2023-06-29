using System.Diagnostics;

namespace SampleAppPractice.Models
{
    public class SmtpClient : IClient
    {
        private readonly ISettings _settings;

        public SmtpClient(ISettings settings)
        {
            _settings = settings;
        }

        public void Send(IMessage message)
        {
            Debug.WriteLine("Message sent by SmtpClient.");
        }

    }

    public class SmtpMessage : IMessage
    {
        public string Body { get ; set ; }
    }
}
