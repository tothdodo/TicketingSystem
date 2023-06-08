namespace TicketingSystemBLL.Dtos
{
    public class NewsDetails
    {
        public int Id { get; set; }
        public string UrlId { get; set; } = null!;
        public string MainTitle { get; set; } = null!;
        public string DetailsTitle { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime PublishDate { get; set; }
        public string Image { get; set; } = null!;
    }
}
