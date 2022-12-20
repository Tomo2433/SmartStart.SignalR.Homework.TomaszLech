using Microsoft.AspNetCore.SignalR;

namespace SignalrChatServer.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync("showString", username, message);
        }
    }
}
