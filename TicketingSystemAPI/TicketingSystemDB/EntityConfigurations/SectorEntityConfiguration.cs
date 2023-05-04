using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystemDB.Entities.Games;

namespace TicketingSystemDB.EntityConfigurations
{
    public class SectorEntityConfiguration : IEntityTypeConfiguration<Sector>
    {        
        public void Configure(EntityTypeBuilder<Sector> builder)
        {
            builder.Property(e => e.SectorName).HasMaxLength(10);
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<Sector> builder)
        {
            builder.HasData(
                    new Sector { Id = 1, SectorName = "A" },
                    new Sector { Id = 2, SectorName = "B" },
                    new Sector { Id = 3, SectorName = "C" },
                    new Sector { Id = 4, SectorName = "D" }
                );
        }
        }
    
}
