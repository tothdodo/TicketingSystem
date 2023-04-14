namespace TicketingSystemDB.Entities
{
    public class Game
    {
        public Game()
        {
            GameSeats = new HashSet<GameSeat>();
        }
        public int Id { get; set; }

        public string Opponent { get; set; } = null!;
        public DateTime StartTime { get; set; } = DateTime.Now.Date;
        public string Place { get; set; } = null!;
        public DateTime BuyStarts { get; set; } = DateTime.Now.Date;
        public DateTime BuyEnds { get; set; } = DateTime.Now.Date;

        public virtual ICollection<GameSeat> GameSeats { get; set; }
    }
}