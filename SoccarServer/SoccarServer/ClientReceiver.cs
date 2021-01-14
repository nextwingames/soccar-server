using System;
using System.Net.Sockets;

namespace SoccarServer
{
    public class ClientReceiver : Nextwin.Server.IReceiver
    {
        public ClientReceiver()
        {
        }

        public void OnReceivedData(int msgType, byte[] receivedData, int clientIndex)
        {
            
        }

        public void OnClientDisconnect(Socket socket)
        {
            throw new NotImplementedException();
        }
    }
}
