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
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "The address field should have a maximum of 15 characters.")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "The phone number field should have a maximum of 10 characters.")]
        [Display(Name = "PhoneNumber")]
        public int PhoneNumber { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string identitfication { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
