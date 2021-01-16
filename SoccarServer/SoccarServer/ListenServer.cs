using System;
using Nextwin.Server;

namespace SoccarServer
{
    public class ListenServer : Nextwin.Server.Server
    {
        private int port;
        public ListenServer(int port)
        {
            this.port = port;
        }

        protected override IReceiver CreateReceiver()
        {
            LobbyClientReceiver receiver = new LobbyClientReceiver();
            return receiver;
        }

        protected override int GetPort()
        {
            return port;
        }
    }
}
