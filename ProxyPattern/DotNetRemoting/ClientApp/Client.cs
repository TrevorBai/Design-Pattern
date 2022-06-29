using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Remoting
{
    // Client class
    public class GumballMonitorClient
    {
        static void Main(string[] args)
        {
            // Create and register the remoting channel
            var channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            GumballMachineServer gumballMachineServer = (GumballMachineServer)Activator.GetObject(typeof(GumballMachineServer), "tcp://localhost:8888/GumballMachineServer");

            if (gumballMachineServer == null)
            {
                Console.WriteLine("Error: unable to locate server");
                return;
            }

            string[] locations =
            {
                "santafe.mightygumball.com",
                "boulder.mightygumball.com",
                "austin.mightygumball.com"
            };

            uint[] gumballCounts = {
                99,
                44,
                187
            };

            for (int i = 0; i < locations.Length; i++)
            {
                gumballMachineServer.GetDataFromClient(locations[i], gumballCounts[i]);
                gumballMachineServer.Report();
            }
            
        }
    }
}
