using Microsoft.AspNetCore.Mvc;
using TicketingSystemBLL.Services;
using TicketingSystemBLL.Dtos;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _playerService;

        public PlayerController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet]
        [Route("team")]
        public async Task<List<PlayerHeader>> GetPlayersAsync()
        {
            return await _playerService.GetPlayers();
        }

        
        [ActionName(nameof(GetPlayerById))]
        [HttpGet]
        [Route("{playerId}")]
        public async Task<ActionResult<PlayerHeader>> GetPlayerById(int playerId)
        {
            var player = await _playerService.GetPlayerOrNull(playerId);

            if (player == null)
                return NotFound();
            else
                return Ok(player);
        }

        [HttpPost]
        async public Task<ActionResult<PlayerHeader>> PostPlayer([FromBody] PlayerHeader player)
        {
            var postedPlayer = await _playerService.PostPlayer(player);

            if(postedPlayer == null)
            {
                return Conflict();
            } else
            {
                return CreatedAtAction(
                    nameof(GetPlayerById),
                    new { playerId = postedPlayer.Id },
                    postedPlayer
                    );
            }
        }

        [HttpDelete]
        [Route("{playerId}")]
        async public Task<ActionResult> DeletePlayer(int playerId)
        {
            var deletedPlayer = await _playerService.GetPlayerOrNull(playerId);
            if (deletedPlayer == null)
            {
                return NotFound();
            }
            else
            {
                await _playerService.DeletePlayer(playerId);
                return NoContent();
            }
        }
    }
}
