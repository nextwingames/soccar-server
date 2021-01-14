using System;
namespace SoccarServer
{
    public class ClientReceiver : Nextwin.Server.IReceiver
    {
        public ClientReceiver()
        {
        }

        public void OnReceivedData(int msgType, byte[] receivedData)
        {
            
        }

        public void OnClientDisconnect()
        {
            throw new NotImplementedException();
        }
    }
}
