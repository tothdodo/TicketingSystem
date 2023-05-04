using TicketingSystemDB.Entities;

namespace TicketingSystemBLL.Dtos
{
    public class GameHeader
    {
        public int Id { get; set; }

        public string Opponent { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public string Place { get; set; } = null!;
        public DateTime BuyStarts { get; set; }
        public DateTime BuyEnds { get; set; }
    }
}
