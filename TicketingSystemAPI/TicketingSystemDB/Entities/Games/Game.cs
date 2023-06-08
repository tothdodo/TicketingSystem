using TicketingSystemDB.Entities.Teams;

namespace TicketingSystemDB.Entities.Games
{
    public class Game
    {
        public Game()
        {
            GameSeats = new HashSet<GameSeat>();
        }
        public int Id { get; set; }

        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; } = null!;

        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; } = null!;
        public DateTime StartTime { get; set; } = DateTime.Now.Date;

        public virtual ICollection<GameSeat> GameSeats { get; set; }
    }
}