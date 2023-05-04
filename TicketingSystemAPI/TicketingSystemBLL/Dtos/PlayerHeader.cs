namespace TicketingSystemBLL.Dtos
{
    public class PlayerHeader
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public int Weigth { get; set; }
        public int Heigth { get; set; }
        public int JerseyNumber { get; set; }
        public string Position { get; set; } = null!;
        public string Source { get; set; } = null!;
    }
}
