namespace SampleAppPractice.Models
{
    public interface IFactory
    {
        public IMessage Create(string message);
    }
}
