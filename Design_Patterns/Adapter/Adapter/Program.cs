
var ports = new List<IVideoPorts>()
{
    new HDMI(),
    new DisplayPort(),
    new USB_C(),
    new DVIAdapter(),
    new VGAAdapter(),
};


foreach(var cables in ports)
{
    cables.Connect();    
}
