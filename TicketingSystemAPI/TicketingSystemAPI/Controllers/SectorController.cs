using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;

        public SectorController(TicketingSystemDB.TSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("{gameid}")]
        public async Task<ActionResult<List<Dtos.SectorHeader>>> GetSectorsAsync(int gameid)
        {
            return _dbContext != null
                ? Ok(await _dbContext.Sectors
                    .Select(sector => new Dtos.SectorHeader
                    {
                        Id = sector.Id,
                        SectorName = sector.SectorName,
                        Rows = _dbContext.Rows
                        .Where(row => row.SectorId == sector.Id)
                        .Select(
                            row => new Dtos.RowHeader
                            {
                                Id = row.Id,
                                RowNumber = row.RowNumber,
                                SectorId = row.SectorId,
                                Seats = _dbContext.Seats.Include(seat => seat.GameSeats)
                                .Where(seat => seat.RowId == row.Id)
                                .Select(
                                    seat => new Dtos.SeatHeader
                                    {
                                        Id = seat.Id,
                                        SeatNumber = seat.SeatNumber,
                                        RowId = seat.RowId,
                                        RowNumber = row.RowNumber,
                                        SectorName = sector.SectorName,
                                        Status = seat.GameSeats
                                            .Where(gs => gs.GameId == gameid && gs.SeatId == seat.Id)
                                            .Select(gs => gs.Status).First()
                                    }).ToList()
                            }).ToList()
                    }).ToListAsync())
                : NotFound();
        }
    }
}
