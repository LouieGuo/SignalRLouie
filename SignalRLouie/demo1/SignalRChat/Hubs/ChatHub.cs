using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo1.SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string method,string user, string message)
        {
            await Clients.All.SendAsync(method, user, message);
        }
    }
}
