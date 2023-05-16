using Microsoft.AspNetCore.SignalR;

namespace Team9.Connect4.API.Hubs
{
    public class Connect4Hub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
