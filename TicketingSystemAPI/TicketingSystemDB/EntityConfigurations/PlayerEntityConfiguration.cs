using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystemDB.Entities;
using TicketingSystemDB.Entities.Players;

namespace TicketingSystemDB.EntityConfigurations
{
    public class PlayerEntityConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(e => e.FirstName).HasMaxLength(100);
            builder.Property(e => e.LastName).HasMaxLength(100);
            builder.Property(e => e.Nationality).HasMaxLength(100);
            builder.Property(e => e.BirthDate).HasMaxLength(50);
            builder.Property(e => e.Weigth).HasMaxLength(10);
            builder.Property(e => e.Heigth).HasMaxLength(10);
            builder.Property(e => e.JerseyNumber).HasMaxLength(10);
            builder.Property(e => e.Position).HasMaxLength(10);
        }
    }
}
