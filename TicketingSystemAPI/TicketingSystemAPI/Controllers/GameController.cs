using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.Dtos;
using TicketingSystemBLL.Services;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameService _gameService;
        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        [Route("games")]
        public async Task<ActionResult<List<GameHeader>>> GetSeatsAsync()
        {
            return await _gameService.GetGames();
        }
    }
}
