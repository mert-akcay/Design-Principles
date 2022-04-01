namespace BridgeDesignPattern;
internal class SamsungTV : ITV
{
    public void SetChannel(int channel)
    {
        Console.WriteLine($"Setting channel to {channel} || Samsung TV");
    }

    public void SwitchOff()
    {
        Console.WriteLine("Turning Off || Samsung TV");
    }

    public void SwitchOn()
    {
        Console.WriteLine("Turning On || Samsung TV");
    }
}


