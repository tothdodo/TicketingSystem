using Microsoft.EntityFrameworkCore;
using TicketingSystemDB.Entities.Games;
using TicketingSystemDB.Entities.News;
using TicketingSystemDB.Entities.Players;
using TicketingSystemDB.Entities.Teams;
using TicketingSystemDB.EntityConfigurations;

namespace TicketingSystemDB
{
    public partial class TSDbContext : DbContext
    {
        public TSDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Seat> Seats => Set<Seat>();
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Sector> Sectors => Set<Sector>();
        public DbSet<Row> Rows => Set<Row>();

        public DbSet<GameSeat> GameSeats => Set<GameSeat>();

        public DbSet<Player> Players => Set<Player>();

        public DbSet<News> News => Set<News>();

        public DbSet<Team> Teams => Set<Team>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new NewsEntityConfiguration());

            modelBuilder.ApplyConfiguration(new TeamEntityConfiguration());

            modelBuilder.ApplyConfiguration(new SectorEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RowEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SeatEntityConfiguration());

            modelBuilder.ApplyConfiguration(new GameEntityConfiguration());
            modelBuilder.ApplyConfiguration(new GameSeatEntityConfiguration());

            modelBuilder.ApplyConfiguration(new PlayerEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}