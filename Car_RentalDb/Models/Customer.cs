using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string LastName { get; set; }
    
        public string Email { get; set; }

        public string Address { get; set; }

        public int PhoneNumber { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string identitfication { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
