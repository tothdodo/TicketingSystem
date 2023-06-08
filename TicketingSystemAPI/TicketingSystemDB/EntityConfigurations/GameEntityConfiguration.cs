using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketingSystemDB.Entities.Games;

namespace TicketingSystemDB.EntityConfigurations
{
    public class GameEntityConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(e => e.StartTime);
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                    new Game { Id = 1, HomeTeamId = 1, AwayTeamId = 2, StartTime = new DateTime(2023, 05, 06, 18, 0, 0) },
                    new Game { Id = 2, HomeTeamId = 4, AwayTeamId = 3, StartTime = new DateTime(2023, 05, 13, 18, 0, 0) },
                    new Game { Id = 3, HomeTeamId = 2, AwayTeamId = 1, StartTime = new DateTime(2023, 05, 20, 18, 0, 0) }
                );
            builder.HasOne(g => g.HomeTeam)
                .WithMany(t => t.HomeGames)
                .HasForeignKey(g => g.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(g => g.AwayTeam)
                .WithMany(t => t.AwayGames)
                .HasForeignKey(g => g.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}