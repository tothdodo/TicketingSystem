using Microsoft.EntityFrameworkCore;
using TicketingSystemBLL.Dtos;
using TicketingSystemDB.Entities.Games;

namespace TicketingSystemBLL.Services
{
    public class GameService
    {
        private readonly TicketingSystemDB.TSDbContext _dbContext;
        private readonly SeatService _seatService;
        private readonly TeamService _teamService;
        public GameService(TicketingSystemDB.TSDbContext dbContext, SeatService seatService, TeamService teamService)
        {
            _dbContext = dbContext;
            _seatService = seatService;
            _teamService = teamService;
        }

        public async Task<List<GameHeader>> GetGames()
        {
            return await _dbContext.Games
                    .Include(g => g.HomeTeam).Include(g => g.AwayTeam).Select(g => new GameHeader
                    {
                        Id = g.Id,
                        HomeTeam = g.HomeTeam.Name,
                        AwayTeam = g.AwayTeam.Name,
                        HomeTeamLogoUrl = g.HomeTeam.LogoUrl,
                        AwayTeamLogoUrl = g.AwayTeam.LogoUrl,
                        StartTime = g.StartTime,
                        Place = g.HomeTeam.HomeCourt
                    }).ToListAsync();
        }

        public async Task<GameHeader?> GetGameOrNull(int gameId)
        {
            var dbGame = await _dbContext.Games.Include(g => g.HomeTeam).Include(g => g.AwayTeam)
                .SingleOrDefaultAsync(g => g.Id == gameId);

            if (dbGame == null)
            {
                return null;
            }
            else
            {
                return new GameHeader
                {
                    Id = dbGame.Id,
                    HomeTeam = dbGame.HomeTeam.Name,
                    AwayTeam = dbGame.AwayTeam.Name,
                    StartTime = dbGame.StartTime,
                    Place = dbGame.HomeTeam.HomeCourt
                };
            }
        }

        public async Task<GameHeader?> PostGame(CreateGame game)
        {
            // Check whether there's another game without a 2 hour range
            //var dbStartTimeCheck = await _dbContext.Games.SingleOrDefaultAsync(g => (g.JerseyNumber == player.JerseyNumber));
            //if (dbStartTimeCheck != null)
            //{
            //    return null;
            //}
            var homeTeam = await _teamService.GetTeamByNameOrNull(game.HomeTeam);

            if(homeTeam == null)
            {
                return null;
            }

            var awayTeam = await _teamService.GetTeamByNameOrNull(game.AwayTeam);
            if(awayTeam == null)
            {
                return null;
            }

            var dbGame = new Game()
            {
                HomeTeamId = homeTeam.Id,
                AwayTeamId = awayTeam.Id,
                StartTime = game.StartTime
            };
            _dbContext.Games.Add(dbGame);
            await _dbContext.SaveChangesAsync();
            await SeedGameWithGameSeats(dbGame);
            await _dbContext.SaveChangesAsync();

            return new GameHeader
            {
                Id = dbGame.Id,
                HomeTeam = homeTeam.Name,
                AwayTeam = awayTeam.Name,
                StartTime = dbGame.StartTime
            };
        }

        private async Task SeedGameWithGameSeats(Game dbGame)
        {
            // 4 Sectors(A..D) -> (Id-s: 1..4)
            for(int i = 1; i < 5; i++)
            {
                // 8 Rows -> (Id-s: 0..7)
                for(int j = 0; j < 8; j++)
                {
                    // Checks whether long or short side of the court
                    if(i % 2 == 0)
                    {
                        await RunThroughTheRow(i, j, 14, dbGame.Id);
                    } else
                    {
                        await RunThroughTheRow(i, j, 22, dbGame.Id);                        
                    }
                }
            }
        }

        private async Task RunThroughTheRow(int i, int j, int rowSeatsCounter, int gameId)
        {
            for (int m = 1; m < 1 + rowSeatsCounter; m++)
            {
                int seatId = CalculateSeatId(i, j, m);
                _ = await _seatService.GetSeatOrNull(seatId) ?? throw new Exception("Seat doesn't exist!");//CheckSeatExist(seatId);
                GameSeat gs = new GameSeat { SeatId = seatId, GameId = gameId, Status = "Available" };
                _dbContext.GameSeats.Add(gs);
            }
        }

        private static int CalculateSeatId(int sectorId, int rowId, int seatNumberId)
        {
            return sectorId * 1000 + rowId * 100 + seatNumberId;
        }

        public async Task DeleteGame(int gameId)
        {
            var dbGameSeatsOfThisGame = await _dbContext.GameSeats
                .Where(gs => gs.GameId == gameId)
                .ToListAsync();
            // Iterate over the var and delete all GameSeat of DB with this GameId
            _dbContext.GameSeats.RemoveRange(dbGameSeatsOfThisGame);

            // Delete the game itself
            var gameToDelete = await _dbContext.Games.FindAsync(gameId);
            _dbContext.Games.Remove(gameToDelete!);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<GameDetails?> GetAllByGameId(int gameId)
        {
            var sectors = await _dbContext.Sectors
                    .Select(sector => new SectorHeader
                    {
                        Id = sector.Id,
                        SectorName = sector.SectorName,
                        Rows = _dbContext.Rows
                        .Where(row => row.SectorId == sector.Id)
                        .Select(
                            row => new RowHeader
                            {
                                Id = row.Id,
                                RowNumber = row.RowNumber,
                                SectorId = row.SectorId,
                                Seats = _dbContext.Seats.Include(seat => seat.GameSeats)
                                .Where(seat => seat.RowId == row.Id)
                                .Select(
                                    seat => new SeatHeader
                                    {
                                        Id = seat.Id,
                                        SeatNumber = seat.SeatNumber,
                                        RowId = seat.RowId,
                                        RowNumber = row.RowNumber,
                                        SectorName = sector.SectorName,
                                        Status = seat.GameSeats
                                            .Where(gs => gs.GameId == gameId && gs.SeatId == seat.Id)
                                            .Select(gs => gs.Status).First()
                                    }).ToList()
                            }).ToList()
                    }).ToListAsync();

            var dbGame = await _dbContext.Games
                .Include(g => g.HomeTeam)
                .Include(g => g.AwayTeam)
                .SingleOrDefaultAsync(g => g.Id == gameId);

            return dbGame != null ? new GameDetails
            {
                Id = dbGame.Id,
                HomeTeam = dbGame.HomeTeam.Name,
                AwayTeam = dbGame.AwayTeam.Name,
                StartTime = dbGame.StartTime,
                HomeTeamLogoUrl = dbGame.HomeTeam.LogoUrl,
                AwayTeamLogoUrl = dbGame.AwayTeam.LogoUrl,
                Sectors = sectors,
                Place = dbGame.HomeTeam.HomeCourt
            } : null;
        }
    }
}
