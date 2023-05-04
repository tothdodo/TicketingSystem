namespace TicketingSystemDB.Entities.Games
{
    public class Row
    {
        public Row()
        {
            Seats = new HashSet<Seat>();
        }

        public int Id { get; set; }
        public int RowNumber { get; set; }

        public int SectorId { get; set; }
        public Sector Sector { get; set; } = null!;

        public virtual ICollection<Seat> Seats { get; set; }
    }
}
