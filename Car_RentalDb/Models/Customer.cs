using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }
        
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter first name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(20)]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter last name")]
        [StringLength(20)]
        public string LastName { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 100 characters")]
        public string Address { get; set; }


        [Required]
        [Range(6400000000,6499999999, ErrorMessage = "Please enter a correct starting and the lenght must be (10).")]
        [Display(Name = "PhoneNumber")]
        public int PhoneNumber { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10,ErrorMessage ="Please enter Yes or No")]
        public string identitfication { get; set; }

        public ICollection<Rental> Rentals { get; set; }
    }
}
