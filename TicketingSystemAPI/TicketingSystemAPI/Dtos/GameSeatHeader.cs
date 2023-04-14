namespace TicketingSystemAPI.Dtos
{
    public class GameSeatHeader
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int SeatId { get; set; }
        public string Sector { get; set; } = null!;
        public int Row { get; set; }
        public int SeatNumber { get; set; }
        public string Status { get; set; } = null!;
    }
}
