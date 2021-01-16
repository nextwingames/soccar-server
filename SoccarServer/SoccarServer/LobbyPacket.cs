using System;
using Nextwin.Server.Protocol;
using System.Collections.Generic;
using MessagePack;

namespace SoccarServer
{
    [MessagePackObject]
    public class LobbyPacket : SerializableData
    {
        [Key(LobbyPacketName.CREATE_ROOM)]
        int createRoom { get; set; }

        [Key(LobbyPacketName.ENTER_ROOM)]
        int enterRoom { get; set; }

        [Key(LobbyPacketName.QUIT_ROOM)]
        int quitRoom { get; set; }

        [Key(LobbyPacketName.REFRESH_ROOM)]
        int refreshRoom { get; set; }

        public LobbyPacket(int msgType) : base(msgType) 
        {
        }
    }
}
