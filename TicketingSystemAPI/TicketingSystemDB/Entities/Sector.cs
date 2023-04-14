namespace TicketingSystemDB.Entities
{
    public class Sector
    {
        public Sector()
        {
            Rows = new HashSet<Row>();
        }
        public int Id { get; set; }
        public string SectorName { get; set; } = null!;
        public virtual ICollection<Row> Rows { get; set; }
    }
}
