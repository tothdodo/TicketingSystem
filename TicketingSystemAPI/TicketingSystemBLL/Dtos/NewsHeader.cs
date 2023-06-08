namespace TicketingSystemBLL.Dtos
{
    public class NewsHeader
    {
        public int Id { get; set; }
        public string UrlId { get; set; } = null!;
        public string MainTitle { get; set; } = null!;
        public string SubTitle { get; set; } = null!;
        public DateTime PublishDate { get; set; }
        public string Image { get; set; } = null!;
    }
}
