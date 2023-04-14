using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TicketingSystemDB.Entities;

namespace TicketingSystemDB.EntityConfigurations
{
    public class UserAddressEntityConfiguration : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.Property(e => e.Type).HasMaxLength(50);
            builder.HasKey(e => new {e.UserId, e.AddressId});
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<UserAddress> builder)
        {
            builder.HasData(
                    new UserAddress
                    {
                        UserId = 1,
                        AddressId = 1,
                        Type = 0
                    },
                    new UserAddress
                    {
                        UserId = 2,
                        AddressId = 2,
                        Type = 1
                    },
                    new UserAddress
                    {
                        UserId = 3,
                        AddressId = 3,
                        Type = 0
                    }
                );

        }
    }
}
