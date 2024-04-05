using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Car
    {
        //primary key is child//
        public int CarID { get; set; }

        //FK which is the parent//
        public int StaffID { get; set; }
        ////
       
        public int LocationID { get; set; }
        //This is the model field//
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(25)]
        public string Model { get; set; }
        //This is the year field//

        [Display(Name = "Year")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public int Year { get; set; }
        //This is the DailyRate field//

        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int DailyRate { get; set; }
        //This is the FuelType field//
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(6)]
        public string FuelType { get; set; }
        //This is the IsAvailable field//
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(15)]
        public string IsAvailable { get; set; }


        //This is the Fk//
        public Staff Staff { get; set; }
        public Location Location { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
