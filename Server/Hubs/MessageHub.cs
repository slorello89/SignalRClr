using Microsoft.AspNetCore.SignalR;
using SignalRClr.Shared;
using System.Threading.Tasks;
namespace SignalRClr.Server.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);            
        }
    }
}