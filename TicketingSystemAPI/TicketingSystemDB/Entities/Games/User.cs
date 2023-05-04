using System.Xml.Linq;

namespace TicketingSystemDB.Entities.Games
{
    public class User
    {
        public User()
        {
            UserAddresses = new HashSet<UserAddress>();
            GameSeats = new HashSet<GameSeat>(); ;
        }
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<GameSeat> GameSeats { get; set; }
    }
}
