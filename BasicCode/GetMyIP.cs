using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    internal class GetMyIP
    {
        public static void ShowMyIPAdress()
        {
            string hostName = Dns.GetHostName(); // Get the host name
            Console.WriteLine("Your host Name: " + hostName);

            IPHostEntry host = Dns.GetHostEntry(hostName); // Get the IP host entry

            foreach (IPAddress ip in host.AddressList)
            {
                // Check if the address family is InterNetwork (IPv4)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("Your IP Address: " + ip.ToString());
                }
            }
        }
    }
}
