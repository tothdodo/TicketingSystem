using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.Dtos;
using TicketingSystemDB.Entities.Players;

namespace TicketingSystemBLL.Services
{
    public class PlayerService
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;
        public PlayerService(TicketingSystemDB.TSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PlayerHeader>> GetPlayers()
        {
            return await _dbContext.Players
                    .Select(p => new PlayerHeader
                    {
                        Id = p.Id,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        Nationality = p.Nationality,
                        BirthDate = p.BirthDate,
                        Weigth = p.Weigth,
                        Heigth = p.Heigth,
                        JerseyNumber = p.JerseyNumber,
                        Position = p.Position,
                        Source = p.Source
                    }).ToListAsync();
        }

        public async Task<PlayerHeader?> GetPlayerOrNull(int playerId)
        {
            var dbPlayer = await _dbContext.Players.SingleOrDefaultAsync(p => p.Id == playerId);

            if (dbPlayer == null)
            {
                return null;
            }
            else
            {
                return new PlayerHeader
                {
                    Id = playerId,
                    FirstName = dbPlayer.FirstName,
                    LastName = dbPlayer.LastName,
                    Nationality = dbPlayer.Nationality,
                    BirthDate = dbPlayer.BirthDate,
                    Weigth = dbPlayer.Weigth,
                    Heigth = dbPlayer.Heigth,
                    JerseyNumber = dbPlayer.JerseyNumber,
                    Position = dbPlayer.Position,
                    Source = dbPlayer.Source
                };
            }
        }

        public async Task<PlayerHeader?> PostPlayer(PlayerHeader player)
        {
            var dbJerseyCheck = await _dbContext.Players.SingleOrDefaultAsync(p => (p.JerseyNumber == player.JerseyNumber));
            if (dbJerseyCheck != null)
            {
                return null;
            }

            var dbPlayer = new Player()
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                Nationality = player.Nationality,
                BirthDate = player.BirthDate,
                Weigth = player.Weigth,
                Heigth = player.Heigth,
                JerseyNumber = player.JerseyNumber,
                Position = player.Position,
                Source = player.Source
            };
            _dbContext.Players.Add(dbPlayer);
            await _dbContext.SaveChangesAsync();


            return new PlayerHeader
            {
                Id = dbPlayer.Id,
                FirstName = dbPlayer.FirstName,
                LastName = dbPlayer.LastName,
                Nationality = dbPlayer.Nationality,
                BirthDate = dbPlayer.BirthDate,
                Weigth = dbPlayer.Weigth,
                Heigth = dbPlayer.Heigth,
                JerseyNumber = dbPlayer.JerseyNumber,
                Position = dbPlayer.Position,
                Source = dbPlayer.Source
            };
        }
        //Delete player from dbContext with playerId
        public async Task DeletePlayer(int playerId)
        {
            var dbPlayer = await _dbContext.Players.SingleOrDefaultAsync(p => p.Id == playerId);
            _dbContext.Players.Remove(dbPlayer!);
            await _dbContext.SaveChangesAsync();
        }
    }
}