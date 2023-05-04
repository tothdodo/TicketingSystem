using Microsoft.AspNetCore.SignalR;
using TicketingSystemBLL.Dtos;

namespace TicketingSystemBLL.HubConfig
{
    public class SeatHub : Hub
    {
        public async Task BroadcastSeatStatus(SeatHeader data) =>
            await Clients.All.SendAsync("broadcastseatstatus", data);
    }
}
