using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketingSystemDB.Entities.Games;

namespace TicketingSystemDB.EntityConfigurations
{
    public class RowEntityConfiguration : IEntityTypeConfiguration<Row>
    {
        public void Configure(EntityTypeBuilder<Row> builder)
        {
            builder.Property(e => e.RowNumber);
            SetData(builder);
        }

        private static void SetData(EntityTypeBuilder<Row> builder)
        {
            builder.HasData(
                    new Row { Id = 100, SectorId = 1, RowNumber = 1 },
                    new Row { Id = 101, SectorId = 1, RowNumber = 2 },
                    new Row { Id = 102, SectorId = 1, RowNumber = 3 },
                    new Row { Id = 103, SectorId = 1, RowNumber = 4 },
                    new Row { Id = 104, SectorId = 1, RowNumber = 5 },
                    new Row { Id = 105, SectorId = 1, RowNumber = 6 },
                    new Row { Id = 106, SectorId = 1, RowNumber = 7 },
                    new Row { Id = 107, SectorId = 1, RowNumber = 8 },

                    new Row { Id = 200, SectorId = 2, RowNumber = 1 },
                    new Row { Id = 201, SectorId = 2, RowNumber = 2 },
                    new Row { Id = 202, SectorId = 2, RowNumber = 3 },
                    new Row { Id = 203, SectorId = 2, RowNumber = 4 },
                    new Row { Id = 204, SectorId = 2, RowNumber = 5 },
                    new Row { Id = 205, SectorId = 2, RowNumber = 6 },
                    new Row { Id = 206, SectorId = 2, RowNumber = 7 },
                    new Row { Id = 207, SectorId = 2, RowNumber = 8 },

                    new Row { Id = 300, SectorId = 3, RowNumber = 1 },
                    new Row { Id = 301, SectorId = 3, RowNumber = 2 },
                    new Row { Id = 302, SectorId = 3, RowNumber = 3 },
                    new Row { Id = 303, SectorId = 3, RowNumber = 4 },
                    new Row { Id = 304, SectorId = 3, RowNumber = 5 },
                    new Row { Id = 305, SectorId = 3, RowNumber = 6 },
                    new Row { Id = 306, SectorId = 3, RowNumber = 7 },
                    new Row { Id = 307, SectorId = 3, RowNumber = 8 },

                    new Row { Id = 400, SectorId = 4, RowNumber = 1 },
                    new Row { Id = 401, SectorId = 4, RowNumber = 2 },
                    new Row { Id = 402, SectorId = 4, RowNumber = 3 },
                    new Row { Id = 403, SectorId = 4, RowNumber = 4 },
                    new Row { Id = 404, SectorId = 4, RowNumber = 5 },
                    new Row { Id = 405, SectorId = 4, RowNumber = 6 },
                    new Row { Id = 406, SectorId = 4, RowNumber = 7 },
                    new Row { Id = 407, SectorId = 4, RowNumber = 8 }
                );
        }
    }
}
