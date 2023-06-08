using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TicketingSystemBLL.Dtos;
using TicketingSystemBLL.Services;
using TicketingSystemDB.Entities.Players;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private TeamService _teamService;
        public TeamController(TeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<List<TeamHeader>> GetTeams()
        {
            return await _teamService.GetTeamsOrNull() ?? new List<TeamHeader>();
        }

        [HttpGet]
        [Route("{teamId}")]
        public async Task<ActionResult<TeamHeader>> GetTeamById(int teamId)
        {
            var team = await _teamService.GetTeamByIdOrNull(teamId);

            if (team == null)
                return NotFound();
            else
                return Ok(team);
        }

        [HttpPost]
        public async Task<ActionResult<TeamHeader>> PostTeam([FromBody] TeamHeader team)
        {
            var postedTeam = await _teamService.PostTeam(team);
            if (postedTeam == null)
                return Conflict();

            return CreatedAtAction(
                        nameof(GetTeamById),
                        new { teamId = postedTeam.Id },
                        postedTeam
                    );
        }

        [HttpDelete]
        [Route("{teamId}")]
        async public Task<ActionResult> DeleteTeam(int teamId)
        {
            var deletedTeam = await _teamService.GetTeamByIdOrNull(teamId);
            if (deletedTeam == null)
            {
                return NotFound();
            }
            else if (await _teamService.CheckHasGames(teamId))
            {
                return StatusCode(StatusCodes.Status405MethodNotAllowed);
            }
            else
            {
                await _teamService.DeleteTeam(teamId);
                return NoContent();
            }
        }
    }
}
