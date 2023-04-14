using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystemDB.Entities;

namespace TicketingSystemDB.EntityConfigurations
{
    public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(e => e.City).HasMaxLength(100);
            builder.Property(e => e.Street).HasMaxLength(255);
            builder.Property(e => e.Zip).HasMaxLength(10);
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
                    new Address {
                        Id = 1,
                        City = "Szombathely",
                        Street = "Kossuth Lajos utca 23.",
                        Zip = "9700"
                    },
                    new Address
                    {
                        Id = 2,
                        City = "Budapest",
                        Street = "Erzsébet utca 17/B",
                        Zip ="1014"
                    },
                    new Address
                    {
                        Id = 3,
                        City = "Veszprém",
                        Street = "Tölgyfa utca 3.",
                        Zip = "8200"
                    }
                );

        }
    }
}
