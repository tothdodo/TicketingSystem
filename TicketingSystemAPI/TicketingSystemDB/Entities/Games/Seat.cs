namespace TicketingSystemDB.Entities.Games
{
    public class Seat
    {
        public Seat()
        {
            GameSeats = new HashSet<GameSeat>();
        }

        public int Id { get; set; }
        public int SeatNumber { get; set; }

        public Row Row { get; set; } = null!;
        public int RowId { get; set; }

        public virtual ICollection<GameSeat> GameSeats { get; set; }
    }
}
