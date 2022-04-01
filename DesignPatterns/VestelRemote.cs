namespace BridgeDesignPattern;

internal class VestelRemote : RemoteAbstract
{
    internal VestelRemote(ITV tv) : base(tv)
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

