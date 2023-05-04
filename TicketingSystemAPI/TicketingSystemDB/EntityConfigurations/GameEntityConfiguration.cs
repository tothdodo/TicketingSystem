using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketingSystemDB.Entities.Games;

namespace TicketingSystemDB.EntityConfigurations
{
    public class GameEntityConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(e => e.Place).HasMaxLength(50);
            builder.Property(e => e.Opponent).HasMaxLength(50);
            builder.Property(e => e.StartTime);
            builder.Property(e => e.BuyStarts);
            builder.Property(e => e.BuyEnds);
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<Game> builder)
        {
            builder.HasData(
                    new Game { Id = 1, Place = "Arena Savaria", Opponent = "DEAC", StartTime = new DateTime(2023, 05, 06, 18, 0, 0) },
                    new Game { Id = 2, Place = "Arena Savaria", Opponent = "Alba Fehérvár", StartTime = new DateTime(2023, 05, 13, 18, 0, 0) },
                    new Game { Id = 3, Place = "Arena Savaria", Opponent = "Szolnoki Olajbányász", StartTime = new DateTime(2023, 05, 20, 18, 0, 0) }
                );

        }
    }
}