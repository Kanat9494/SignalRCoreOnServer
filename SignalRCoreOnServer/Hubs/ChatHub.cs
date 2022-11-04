namespace SignalRCoreOnServer.Hubs;

public class ChatHub : Hub
{
    public async Task Send(string userName, string message)
    {
        await this.Clients.All.SendAsync("Receive", userName, message);
    }
}
