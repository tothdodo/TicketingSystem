using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.HubConfig;
using TicketingSystemBLL.Dtos;
using TicketingSystemDB.Entities.Games;
using TicketingSystemBLL.TimerFeatures;
using Microsoft.AspNetCore.SignalR;

namespace TicketingSystemBLL.Services
{
    public class SeatService
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;

        private readonly IHubContext<SeatHub> _hub;
        public SeatService(TicketingSystemDB.TSDbContext dbContext, IHubContext<SeatHub> hub)
        {
            _dbContext = dbContext;
            _hub = hub;
        }

        public async Task<List<SeatHeader>> GetSeats()
        {
            return await _dbContext.Seats
                    .Select(s => new SeatHeader
                    {
                        Id = s.Id,
                        SeatNumber = s.SeatNumber,
                    }).ToListAsync();
        }

        public async Task<GameSeat?> GetGameSeat(int seatId, int gameId)
        {
            return await _dbContext.GameSeats.SingleOrDefaultAsync(
                gameSeat => (gameSeat.GameId == gameId) && (gameSeat.SeatId == seatId));
        }

        public async Task<SeatHeader> PutSeatStatus(GameSeat dbGameSeat, SeatHeader seat)
        {
            if (seat.Status == "Bought")
            {
                var timerManager = new TimerManager(
                        () => _hub.Clients.All.SendAsync("transferseatstatus", seat)
                    );
            }

            dbGameSeat.Status = seat.Status;
            await _dbContext.SaveChangesAsync();

            return new SeatHeader
            {
                Id = seat.Id,
                Status = dbGameSeat.Status,
                SeatNumber = seat.SeatNumber
            };
        }
    }
}
