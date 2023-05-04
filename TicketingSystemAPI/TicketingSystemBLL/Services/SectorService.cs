using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.Dtos;
using TicketingSystemDB.Entities.Games;

namespace TicketingSystemBLL.Services
{
    public class SectorService
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;
        public SectorService(TicketingSystemDB.TSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SectorHeader>> GetSectorsByGameId(int gameId)
        {
            return await _dbContext.Sectors
                    .Select(sector => new SectorHeader
                    {
                        Id = sector.Id,
                        SectorName = sector.SectorName,
                        Rows = _dbContext.Rows
                        .Where(row => row.SectorId == sector.Id)
                        .Select(
                            row => new RowHeader
                            {
                                Id = row.Id,
                                RowNumber = row.RowNumber,
                                SectorId = row.SectorId,
                                Seats = _dbContext.Seats.Include(seat => seat.GameSeats)
                                .Where(seat => seat.RowId == row.Id)
                                .Select(
                                    seat => new SeatHeader
                                    {
                                        Id = seat.Id,
                                        SeatNumber = seat.SeatNumber,
                                        RowId = seat.RowId,
                                        RowNumber = row.RowNumber,
                                        SectorName = sector.SectorName,
                                        Status = seat.GameSeats
                                            .Where(gs => gs.GameId == gameId && gs.SeatId == seat.Id)
                                            .Select(gs => gs.Status).First()
                                    }).ToList()
                            }).ToList()
                    }).ToListAsync();
        }
    }
}
