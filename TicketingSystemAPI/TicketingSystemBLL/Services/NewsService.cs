using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.Dtos;
using TicketingSystemDB.Entities.News;
using TicketingSystemDB.Entities.Players;

namespace TicketingSystemBLL.Services
{
    public class NewsService
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;
        public NewsService(TicketingSystemDB.TSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<NewsHeader>> GetNewsHeader()
        {
            return await _dbContext.News
                    .Select(n => new NewsHeader
                    {
                        Id = n.Id,
                        UrlId = n.UrlId,
                        MainTitle = n.MainTitle,
                        SubTitle = n.SubTitle,
                        PublishDate = n.PublishDate,
                        Image = n.Image,
                    }).ToListAsync();
        }

        public async Task<NewsDetails?> GetNewsOrNull(string newsUrlId)
        {
            var dbNews = await _dbContext.News.SingleOrDefaultAsync(n => n.UrlId == newsUrlId);

            if (dbNews == null)
            {
                return null;
            }
            else
            {
                return new NewsDetails
                {
                    Id = dbNews.Id,
                    UrlId = dbNews.UrlId,
                    MainTitle = dbNews.MainTitle,
                    DetailsTitle = dbNews.DetailsTitle,
                    Content = dbNews.Content,
                    PublishDate = dbNews.PublishDate,
                    Image = dbNews.Image
                };
            }
        }

        public async Task<CreateNews?> Insert(CreateNews value)
        {
            var dbNews = await _dbContext.News.SingleOrDefaultAsync(n => n.UrlId == value.UrlId);
            while (dbNews != null)
            {
                value.UrlId += "-1";
                dbNews = await _dbContext.News.SingleOrDefaultAsync(n => n.UrlId == value.UrlId);
            }
            dbNews = new News
            {
                UrlId = value.UrlId,
                MainTitle = value.MainTitle,
                SubTitle = value.SubTitle,
                DetailsTitle = value.DetailsTitle,
                Content = value.Content,
                PublishDate = value.PublishDate,
                Image = value.Image
            };
            _dbContext.News.Add(dbNews);
            await _dbContext.SaveChangesAsync();
            return new CreateNews
            {
                Id = dbNews.Id,
                UrlId = dbNews.UrlId,
                MainTitle = dbNews.MainTitle,
                SubTitle = dbNews.SubTitle,
                DetailsTitle = dbNews.DetailsTitle,
                Content = dbNews.Content,
                PublishDate = dbNews.PublishDate,
                Image = dbNews.Image
            };

        } 
    }
}
