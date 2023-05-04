using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.Dtos;
using TicketingSystemBLL.Services;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly SectorService _sectorService;

        public SectorController(SectorService sectorService)
        {
            _sectorService = sectorService;
        }

        [HttpGet]
        [Route("{gameId}")]
        public async Task<List<SectorHeader>> GetSectorsAsync(int gameId)
        {
            return await _sectorService.GetSectorsByGameId(gameId);
        }
    }
}
