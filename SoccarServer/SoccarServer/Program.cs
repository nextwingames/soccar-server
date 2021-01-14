using System;
using System.Net;
using System.Net.Sockets;
using Nextwin.Util;

namespace SoccarServer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ListenServer listenServer = new ListenServer(9999);
            listenServer.Listen();
            Console.WriteLine("Start Listen");
            while(true)
            {
                string input = Console.ReadLine();
                Console.WriteLine("You Typed : " + input);
            }
        }
    }
}
