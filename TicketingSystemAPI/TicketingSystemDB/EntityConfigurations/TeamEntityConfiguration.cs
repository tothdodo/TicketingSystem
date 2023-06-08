using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TicketingSystemDB.Entities.Teams;

namespace TicketingSystemDB.EntityConfigurations
{
    public class TeamEntityConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.HomeCourt).HasMaxLength(100);
            builder.Property(e => e.LogoUrl).HasMaxLength(100);
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(
                    new Team
                    {
                        Id = 1,
                        Name = "Falco KC Szombathely",
                        HomeCourt = "Arena Savaria",
                        LogoUrl = "falco-logo.png"
                    },
                    new Team
                    {
                        Id = 2,
                        Name = "Alba Fehérvár",
                        HomeCourt = "Gáz utcai Sportcsarnok",
                        LogoUrl = "alba-logo.png"
                    },
                    new Team
                    {
                        Id = 3,
                        Name = "Szolnoki Olajbányász",
                        HomeCourt = "Tiszaligeti Sportcsarnok",
                        LogoUrl = "szolnok-logo.png"
                    },
                    new Team
                    {
                        Id = 4,
                        Name = "DEAC",
                        HomeCourt = "DEAC Arena",
                        LogoUrl = "deac-logo.png"
                    }
                );

        }
    }
}
