class DVIAdapter : DVI, IVideoPorts
{
    public void Connect()
    {
        ConnectDVI();
        Console.WriteLine(" with adapter");
    }

}
