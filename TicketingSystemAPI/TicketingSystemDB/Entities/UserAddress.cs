using TicketingSystemDB.Entities.Games;

namespace TicketingSystemDB.Entities
{
    public class UserAddress
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public int Type { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}