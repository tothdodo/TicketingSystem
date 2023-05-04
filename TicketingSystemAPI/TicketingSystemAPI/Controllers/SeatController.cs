using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TicketingSystemBLL.Dtos;
using TicketingSystemBLL.Services;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly SeatService _seatService;


        public SeatController(SeatService seatService)
        {
            _seatService = seatService;
        }
        
        [HttpGet]
        [Route("seats")]
        public async Task<List<SeatHeader>> GetSeatsAsync()
        {
            return await _seatService.GetSeats();
        }

        [HttpPut]
        [Route("{gameId}")]
        public async Task<ActionResult<SeatHeader>> ModifyAsync([FromBody] SeatHeader seat, [FromRoute] int gameId)
        {
            var dbGameSeat = await _seatService.GetGameSeat(seat.Id, gameId);
            if (dbGameSeat == null)
            {
                return NotFound();
            }
            return Ok(await _seatService.PutSeatStatus(dbGameSeat, seat));
        }
    }
}
