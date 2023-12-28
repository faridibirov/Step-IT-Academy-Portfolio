class VGAAdapter : IVideoPorts
{
    private readonly VGA? vga = null;

    public VGAAdapter()
    {
        vga = new VGA();
    }

    public void Connect()
    {
        vga?.ConnectVGA();
        Console.WriteLine(" with adapter");
    }
}
