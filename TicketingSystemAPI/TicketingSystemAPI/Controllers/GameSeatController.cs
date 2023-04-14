using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketingSystemDB.Entities;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameSeatController : ControllerBase
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;
        public GameSeatController(TicketingSystemDB.TSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /*
        [HttpGet]
        [Route("{gameId}")]
        public async Task<ActionResult<List<Dtos.GameSeatHeader>>> GetGameSeatByGameIdAsync(int gameId)
        {
            var filteredList = _dbContext.GameSeats.Where(gs => gs.GameId == gameId);

            return filteredList != null
                ? Ok(await filteredList
                    .Select(gs => new Dtos.GameSeatHeader
                    {
                        Id = gs.SeatId,
                        SeatId = gs.SeatId,
                        GameId = gs.GameId,
                        Status = gs.Status,
                        Row = gs.Seat.Row,
                        Sector = gs.Seat.Sector,
                        SeatNumber = gs.Seat.SeatNumber,
                    }).ToListAsync())
                : NotFound();
        }

        [HttpPut]
        public async Task<ActionResult<Dtos.GameSeatHeader>> ModifyAsync([FromBody]Dtos.GameSeatHeader gs)
        {
            var dbGameSeat = await _dbContext.GameSeats.SingleOrDefaultAsync(gameSeat => ((gameSeat.GameId == gs.GameId) && (gameSeat.SeatId == gs.SeatId)));
            if(dbGameSeat == null)
            {
                return NotFound();
            }

            var dbSeat = await _dbContext.Seats.SingleOrDefaultAsync(seat => seat.Id == dbGameSeat.SeatId);

            if (dbSeat == null)
            {
                return NotFound();
            }

            dbGameSeat.Status = gs.Status;
            _dbContext.SaveChanges();

            return Ok(new Dtos.GameSeatHeader{
                    Id = dbGameSeat.SeatId,
                    SeatId = dbGameSeat.SeatId,
                    GameId = dbGameSeat.GameId,
                    Status = dbGameSeat.Status,
                    Row = dbSeat.Row,
                    Sector = dbSeat.Sector,
                    SeatNumber = dbSeat.SeatNumber
                }
            );
        }*/
    }
}
