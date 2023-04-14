using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TicketingSystemAPI.HubConfig;
using TicketingSystemAPI.TimerFeatures;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;

        private readonly IHubContext<SeatHub> _hub;

        public SeatController(TicketingSystemDB.TSDbContext dbContext, IHubContext<SeatHub> hub)
        {
            _dbContext = dbContext;
            _hub = hub;
        }
        
        [HttpGet]
        [Route("seats")]
        public async Task<ActionResult<List<Dtos.SeatHeader>>> GetSeatsAsync()
        {
            return _dbContext != null
                ? Ok(await _dbContext.Seats
                    .Select(s => new Dtos.SeatHeader
                    {
                        Id = s.Id,
                        SeatNumber = s.SeatNumber,
                    }).ToListAsync())
                : NotFound();
        }

        [HttpPut]
        [Route("{gameId}")]
        public async Task<ActionResult<Dtos.SeatHeader>> ModifyAsync([FromBody] Dtos.SeatHeader seat, [FromRoute] int gameId)
        {
            var dbGameSeat = await _dbContext.GameSeats.SingleOrDefaultAsync(gameSeat => ((gameSeat.GameId == gameId) && (gameSeat.SeatId == seat.Id)));
            if (dbGameSeat == null)
            {
                return NotFound();
            }

            if(seat.Status == "Bought")
            {
                var timerManager = new TimerManager(
                        () => _hub.Clients.All.SendAsync("transferseatstatus", seat)
                    );
            }

            dbGameSeat.Status = seat.Status;
            _dbContext.SaveChanges();

            return Ok(new Dtos.SeatHeader
            {
                Id = seat.Id,
                Status = dbGameSeat.Status,
                SeatNumber = seat.SeatNumber
            }
            );
        }
        /*
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Dtos.SeatHeader>> GetSeatAsync(int id)
        {
            var dbSeat = await _dbContext.Seats.SingleOrDefaultAsync(s =>  s.Id == id);
            return dbSeat != null
                ? Ok(new Dtos.SeatHeader
                {
                    Id = id,
                    Row = dbSeat.Row,
                    Sector = dbSeat.Sector,
                    SeatNumber = dbSeat.SeatNumber
                })
                : NotFound();
        }*/
    }
}
