namespace BridgeDesignPattern;
internal class VestelTV : ITV
{
    public void SetChannel(int channel)
    {
        Console.WriteLine($"Setting channel to {channel} || Vestel TV");
    }

    public void SwitchOff()
    {
        Console.WriteLine("Turning OfF || Vestel TV");
    }

    public void SwitchOn()
    {
        Console.WriteLine("Turning On || Vestel TV");
    }
}
