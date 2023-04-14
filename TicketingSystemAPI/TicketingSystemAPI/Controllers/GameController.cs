using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;
        public GameController(TicketingSystemDB.TSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("games")]
        public async Task<ActionResult<List<Dtos.GameHeader>>> GetSeatsAsync()
        {

            return _dbContext != null
                ? Ok(await _dbContext.Games
                    .Select(g => new Dtos.GameHeader
                    {
                        Id = g.Id,
                        Opponent = g.Opponent,
                        StartTime = g.StartTime,
                        BuyStarts = g.BuyStarts,
                        BuyEnds = g.BuyEnds,
                    }).ToListAsync())
                : NotFound();
        }
    }
}
