namespace SampleAppPractice.Models
{
    public interface IClient
    {
        public void Send(IMessage message);
    }
}
