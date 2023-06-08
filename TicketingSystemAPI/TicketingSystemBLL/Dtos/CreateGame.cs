namespace TicketingSystemBLL.Dtos
{
    public class CreateGame
    {
        public string HomeTeam { get; set; } = null!;
        public string AwayTeam { get; set; } = null!;
        public DateTime StartTime { get; set; }
    }
}
