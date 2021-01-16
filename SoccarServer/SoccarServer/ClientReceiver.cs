using System;
using System.Net.Sockets;

namespace SoccarServer
{
    public class LobbyClientReceiver : Nextwin.Server.IReceiver
    {
        public LobbyClientReceiver()
        {
        }

        public void OnReceivedData(int msgType, byte[] receivedData, int clientIndex)
        {
            switch (msgType)
            {
                case LobbyPacketName.CREATE_ROOM:
                    break;
                case LobbyPacketName.ENTER_ROOM:
                    break;
                case LobbyPacketName.QUIT_ROOM:
                    break;
                case LobbyPacketName.REFRESH_ROOM:
                    break;
                default:
                    break;
            }
        }

        public void OnClientDisconnect(Socket socket)
        {
            throw new NotImplementedException();
        }
    }
}
