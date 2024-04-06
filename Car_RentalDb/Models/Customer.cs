using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Customer
    {
        //This is the primary Key//
        public int CustomerId { get; set; }
        //This is the Name field//
        //The vaildation stops users from entering number and special letters//
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        //This is the last name field//
        //The vaildation stops users from entering number and special letters//

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string LastName { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 100 characters")]
        public string Address { get; set; }


        [Required]
        [StringLength(10, ErrorMessage = "The phone number field should have a maximum of 10 characters.")]
        [Display(Name = "PhoneNumber")]
        public int PhoneNumber { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10,ErrorMessage ="Please enter Yes or No")]
        public string identitfication { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
