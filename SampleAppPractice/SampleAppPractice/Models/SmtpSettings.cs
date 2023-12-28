namespace SampleAppPractice.Models
{
    public class SmtpSettings : ISettings
    {
        public int Port { get; set; }
        public string Host { get; set; }
    }
}
