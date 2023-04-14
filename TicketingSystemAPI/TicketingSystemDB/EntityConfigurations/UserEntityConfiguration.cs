using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketingSystemDB.Entities;

namespace TicketingSystemDB.EntityConfigurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Email).HasMaxLength(50);
            builder.Property(e => e.Username).HasMaxLength(50);
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                    new User { Id = 1, Username = "BiggestFan", Email = "biggestfan@gmail.com" },
                    new User { Id = 2, Username = "JustWatchingMan", Email = "jwman@gmail.com" },
                    new User { Id = 3, Username = "Guy Ritchie", Email = "guyritchie@citromail.hu" }
                );

        }
    }
}
