using System.Collections.Generic;
using TicketingSystemDB.Entities;

namespace TicketingSystemAPI.Dtos
{
    public class RowHeader
    {
        public RowHeader()
        {
            Seats = new List<SeatHeader>();
        }

        public int Id { get; set; }
        public int RowNumber { get; set; }

        public int SectorId { get; set; }

        public virtual List<SeatHeader> Seats { get; set; } = null!;
    }
}
