using TicketingSystemDB.Entities;

namespace TicketingSystemBLL.Dtos
{
    public class SeatHeader
    {
        public SeatHeader()
        {
            GameSeats = new List<GameSeatHeader>();
        }

        public int Id { get; set; }
        public int SeatNumber { get; set; }

        public int RowId { get; set; }

        public int RowNumber { get; set; }

        public string SectorName { get; set; } = null!;

        public string Status { get; set; } = null!;

        public virtual List<GameSeatHeader> GameSeats { get; set; }

    }
}
