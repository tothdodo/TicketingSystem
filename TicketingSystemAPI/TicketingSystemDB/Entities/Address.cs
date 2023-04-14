namespace TicketingSystemDB.Entities
{
    public class Address
    {
        public Address()
        {
            UserAddresses = new HashSet<UserAddress>();
        }
        public int Id { get; set; }
        public string City { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Street { get; set; } = null!;
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}