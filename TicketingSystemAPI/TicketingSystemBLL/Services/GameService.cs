using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.Dtos;

namespace TicketingSystemBLL.Services
{
    public class GameService
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;
        public GameService(TicketingSystemDB.TSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<GameHeader>> GetGames()
        {
            return await _dbContext.Games
                    .Select(g => new GameHeader
                    {
                        Id = g.Id,
                        Opponent = g.Opponent,
                        StartTime = g.StartTime,
                        BuyStarts = g.BuyStarts,
                        BuyEnds = g.BuyEnds,
                    }).ToListAsync();
        }
    }
}
