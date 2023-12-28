namespace SampleAppPractice.Models
{
    public class MessageFactory: IFactory
    {
    
        IMessage IFactory.Create(string message)
        {
            return new SmtpMessage() { Body = message };
        }
    }
}
