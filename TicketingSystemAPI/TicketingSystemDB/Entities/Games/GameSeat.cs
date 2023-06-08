namespace TicketingSystemDB.Entities.Games
{
    public class GameSeat
    {
        public int GameId { get; set; }

        public int SeatId { get; set; }

        public int? UserId { get; set; }

        public string Status { get; set; } = null!;

        public virtual Game Game { get; set; } = null!;
        public virtual Seat Seat { get; set; } = null!;
    }
}
