using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
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
        [StringLength(10, ErrorMessage = "The phone field should have a maximum of 10 characters.")]
        [Display(Name = "Phone")]
        public int Phone { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Please enter vaild activety from Avtive or Not Active")]
        [Required]
        [StringLength(13)]
        public string Active { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 100 characters")]
        public string Address { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
