using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Location
    {
        public int LocationID { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Address must be between 5 and 100 characters")]
        public string Address { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string City { get; set; }
        [Required]
        [Range(1000, 2000, ErrorMessage = "Please enter a vaild model year (From 1000 - 2000")]

        public int Zip { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(20)]
        public string Country { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public DateTime OpeningHours { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public DateTime ClosingHours { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
