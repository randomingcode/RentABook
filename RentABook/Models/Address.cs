namespace RentABook.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string district { get; set; }
        public string Street { get; set; }
        public string Apartment { get; set; }
        public string Door { get; set; }
        public User User { get; set; }
    }
}
