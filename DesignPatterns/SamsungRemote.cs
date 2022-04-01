namespace BridgeDesignPattern;

internal class SamsungRemote : RemoteAbstract
{
    internal SamsungRemote(ITV tv) : base(tv)
    {

    }

    internal override void SetChannel(int channel)
    {
        tv.SetChannel(channel);
    }

    internal override void SwitchOff()
    {
        tv.SwitchOff();
    }

    internal override void SwitchOn()
    {
        tv.SwitchOn();
    }
}

