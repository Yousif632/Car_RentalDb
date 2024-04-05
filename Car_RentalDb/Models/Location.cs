using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Address { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(10)]
        public string City { get; set; }

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
