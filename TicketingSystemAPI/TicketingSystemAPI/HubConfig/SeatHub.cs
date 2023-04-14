using Microsoft.AspNetCore.SignalR;
using TicketingSystemAPI.Dtos;

namespace TicketingSystemAPI.HubConfig
{
    public class SeatHub : Hub
    {
        public async Task BroadcastSeatStatus(SeatHeader data) =>
            await Clients.All.SendAsync("broadcastseatstatus", data);
    }
}
