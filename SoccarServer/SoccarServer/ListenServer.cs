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
            ClientReceiver receiver = new ClientReceiver();
            return receiver;
        }

        protected override int GetPort()
        {
            return port;
        }
    }
}
