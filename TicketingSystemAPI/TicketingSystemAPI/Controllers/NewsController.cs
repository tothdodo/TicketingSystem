using Microsoft.AspNetCore.Mvc;
using TicketingSystemBLL.Dtos;
using TicketingSystemBLL.Services;

namespace TicketingSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly NewsService _newsService;
        public NewsController(NewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<NewsHeader>>> GetNewsHeader()
        {
            return await _newsService.GetNewsHeader();
        }

        [HttpGet("{newsUrlId}")]
        public async Task<ActionResult<NewsDetails>> GetNews(string newsUrlId)
        {
            var news = await _newsService.GetNewsOrNull(newsUrlId);
            if (news == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(news);
            }
        }

        [HttpPost]
        public async Task<ActionResult> PostNews(CreateNews value)
        {
            var insertedValue = await _newsService.Insert(value);
            return insertedValue != null
                ? CreatedAtAction(nameof(GetNews), new { newsUrlId = insertedValue.Id }, insertedValue)
                : BadRequest();
        }
    }
}
