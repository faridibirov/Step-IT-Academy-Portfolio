namespace SampleAppPractice.Models
{
    public class Messanger : IMessanger
    {
        private readonly IClient _client;
        private readonly IFactory _factory;

        public Messanger(IClient client, IFactory factory)
        {
            _client = client;
            _factory = factory;
        }

        public void SendMessage(string message, string user)
        {
            IMessage smtpMessage = _factory.Create(message);
            _client.Send(smtpMessage);
        }
    }
}
