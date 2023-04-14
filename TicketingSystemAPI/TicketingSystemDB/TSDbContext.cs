using Microsoft.EntityFrameworkCore;
using TicketingSystemDB.Entities;
using TicketingSystemDB.EntityConfigurations;

namespace TicketingSystemDB
{
    public partial class TSDbContext : DbContext
    {
        public TSDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Seat> Seats => Set<Seat>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Sector> Sectors => Set<Sector>();
        public DbSet<Row> Rows => Set<Row>();

        public DbSet<GameSeat> GameSeats => Set<GameSeat>();
        public DbSet<UserAddress> UserAddresses => Set<UserAddress>();
        public DbSet<Address> Addresses => Set<Address>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new SectorEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RowEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SeatEntityConfiguration());

            modelBuilder.ApplyConfiguration(new GameEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserAddressEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new GameSeatEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
