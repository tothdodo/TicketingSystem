namespace TicketingSystemBLL.Dtos
{
    public class TeamHeader
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
        public string HomeCourt { get; set; } = null!;
    }
}
