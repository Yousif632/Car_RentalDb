namespace Car_RentalDb.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string identitfication { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
