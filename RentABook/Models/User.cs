using RentABook.Models.ENUMS;

namespace RentABook.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public GenderEnum?  Gender { get; set; }
        public List<Address> Addresses {  get; set; }

    }
}
