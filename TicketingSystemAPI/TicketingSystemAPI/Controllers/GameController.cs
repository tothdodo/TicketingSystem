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

        [ActionName(nameof(GetGameById))]
        [HttpGet]
        [Route("{gameId}")]
        public async Task<ActionResult<GameHeader>> GetGameById(int gameId)
        {
            var game = await _gameService.GetGameOrNull(gameId);

            if (game == null)
                return NotFound();
            else
                return Ok(game);
        }

        [HttpGet]
        [Route("games/{gameId}")]
        public async Task<ActionResult<GameDetails?>> GetAllByGameId(int gameId)
        {
            return await _gameService.GetAllByGameId(gameId);
        }

        [HttpPost]
        public async Task<ActionResult<GameHeader>> PostGame([FromBody] CreateGame game)
        {
            var postedGame = await _gameService.PostGame(game);

            // There's another game within a 2 hours range
            if (postedGame == null)
            {
                return Conflict();
            }
            else
            {
                return CreatedAtAction(
                    nameof(GetGameById),
                    new { gameId = postedGame.Id },
                    postedGame
                    );
            }
        }

        [HttpDelete]
        [Route("{gameId}")]
        async public Task<ActionResult> DeleteGame(int gameId)
        {
            var deletedGame = await _gameService.GetGameOrNull(gameId);
            if (deletedGame == null)
            {
                return NotFound();
            }
            else
            {
                await _gameService.DeleteGame(gameId);
                return NoContent();
            }
        }
    }
}
