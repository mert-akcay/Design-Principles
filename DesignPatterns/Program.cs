using BridgeDesignPattern;

VestelRemote vestelRemote = new VestelRemote(new VestelTV());
vestelRemote.SwitchOn();
vestelRemote.SetChannel(10);
vestelRemote.SwitchOff();

Console.WriteLine();

SamsungRemote samsungRemote = new SamsungRemote(new SamsungTV());
samsungRemote.SwitchOn();
samsungRemote.SetChannel(20);
samsungRemote.SwitchOff();

Console.ReadKey();