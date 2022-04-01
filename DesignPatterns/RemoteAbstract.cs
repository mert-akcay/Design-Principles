namespace BridgeDesignPattern;

internal abstract class RemoteAbstract
{
    protected ITV tv;

    protected RemoteAbstract(ITV tv)
    {
        this.tv = tv;
    }

    internal abstract void SwitchOn();
    internal abstract void SwitchOff();
    internal abstract void SetChannel(int channel);
}

