using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace chat_server
{
    public class ChatHub : Hub<IChatHub>
    {
        public async Task BroadcastAsync(ChatMessage message)
        {
            Debug.WriteLine(message.Text);
            await Clients.All.MessageReceivedFromHub(message);
        }

        public async Task UpdateSchedulerEvent(UpdateMessage message)
        {
            Debug.WriteLine("event ID: " + message.EventId);
            await Clients.All.UpdateReceived(message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.NewUserConnected("a new user connectd");
        }
    }

    public interface IChatHub
    {
        Task MessageReceivedFromHub(ChatMessage message);

        Task UpdateReceived(UpdateMessage message);

        Task NewUserConnected(string message);
    }
}
