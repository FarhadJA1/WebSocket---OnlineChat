using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSocket.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string username,string message)
        {
            await Clients.All.SendAsync("RecieveMessage",username,message);
        }
    }
}
