using TicketingSystemDB.Entities;

namespace TicketingSystemBLL.Dtos
{
    public class SectorHeader
    {
        public SectorHeader()
        {
            Rows = new List<RowHeader>();
        }
        public int Id { get; set; }
        public string SectorName { get; set; } = null!;
        public virtual List<RowHeader> Rows { get; set; } = null!;
    }
}
