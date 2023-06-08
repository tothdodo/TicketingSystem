using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.Dtos;
using TicketingSystemDB.Entities.Players;
using TicketingSystemDB.Entities.Teams;

namespace TicketingSystemBLL.Services
{
    public class TeamService
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;
        public TeamService(TicketingSystemDB.TSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CheckHasGames(int teamId)
        {
            var dbGames = await _dbContext.Games
                .Where(g => g.AwayTeamId == teamId || g.HomeTeamId == teamId).ToListAsync();

            return dbGames.Count > 0;
        }

        public async Task DeleteTeam(int teamId)
        {
            var dbTeam = await _dbContext.Teams.SingleOrDefaultAsync(t => t.Id == teamId);
            _dbContext.Teams.Remove(dbTeam!);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<TeamHeader?> GetTeamByIdOrNull(int teamId)
        {
            var dbTeam = await _dbContext.Teams.SingleOrDefaultAsync(t => t.Id == teamId);

            if (dbTeam == null)
            {
                return null;
            }
            else
            {
                return new TeamHeader
                {
                    Id = dbTeam.Id,
                    HomeCourt = dbTeam.HomeCourt,
                    LogoUrl = dbTeam.LogoUrl,
                    Name = dbTeam.Name
                };
            }
        }

        public async Task<TeamHeader?> GetTeamByNameOrNull(string teamName)
        {
            var dbTeam = await _dbContext.Teams.SingleOrDefaultAsync(t => t.Name == teamName);

            if (dbTeam == null)
            {
                return null;
            }
            else
            {
                return new TeamHeader
                {
                    Id = dbTeam.Id,
                    HomeCourt = dbTeam.HomeCourt,
                    LogoUrl = dbTeam.LogoUrl,
                    Name = dbTeam.Name
                };
            }
        }

        public async Task<List<TeamHeader>?> GetTeamsOrNull()
        {
            return await _dbContext.Teams
                    .Select(t => new TeamHeader
                    {
                        Id = t.Id,
                        Name = t.Name,
                        LogoUrl = t.LogoUrl,
                        HomeCourt = t.HomeCourt
                    }).ToListAsync();
        }

        public async Task<TeamHeader?> PostTeam(TeamHeader team)
        {
            var dbTeam = new Team()
            {
                HomeCourt = team.HomeCourt,
                Name = team.Name,
                LogoUrl = team.LogoUrl,
            };
            _dbContext.Teams.Add(dbTeam);
            await _dbContext.SaveChangesAsync();


            return new TeamHeader
            {
                Id = dbTeam.Id,
                Name = dbTeam.Name,
                HomeCourt = dbTeam.HomeCourt,
                LogoUrl = dbTeam.LogoUrl
            };
        }
    }
}
