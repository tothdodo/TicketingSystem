namespace TicketingSystemBLL.Dtos
{
    public class GameDetails
    {
        public GameDetails()
        {
            Sectors = new List<SectorHeader>();
        }
        public int Id { get; set; }

        public string HomeTeam { get; set; } = null!;
        public string AwayTeam { get; set; } = null!;
        public string HomeTeamLogoUrl { get; set; } = null!;
        public string AwayTeamLogoUrl { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public string Place { get; set; } = null!;
        public virtual List<SectorHeader> Sectors { get; set; } = null!;
    }
}
