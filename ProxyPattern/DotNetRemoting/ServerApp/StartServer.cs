using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Remoting
{
    class StartServer
    {
        static void Main()
        {
            // Create and register the channel at 8888
            var channel = new TcpChannel(8888);

            ChannelServices.RegisterChannel(channel, false);
            Console.WriteLine("Starting GumballMachineServer");

            // Register the GumballMachineServer for remoting
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(GumballMachineServer), "GumballMachineServer", WellKnownObjectMode.SingleCall);
            Console.WriteLine("Press return to exit GumballMachineServer");
            Console.ReadLine();
        }
    }
}
