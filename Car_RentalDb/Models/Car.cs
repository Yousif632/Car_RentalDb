using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public enum FuelType
    {
        Petrol,
        Diesel,
        PetrolSupreme

    }
    public class Car
    {
        
        //primary key is child//
        public int CarID { get; set; }

        //FK which is the parent//
        public int StaffID { get; set; }

        //Fk which is the parent//
        public int LocationID { get; set; }

        //This is the model field//
        //This validation blocks users from entering special character and numbers and has the stringlenght of 25//
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(25)]
        public string Model { get; set; }
        //This is the year field//

        [Required]
        [Range(2000,2024,ErrorMessage ="Please enter a vaild model year (From 2000 - 2024)")]
        public int Year { get; set; }
        //This is the DailyRate field//
        //The Validation is that daily rate must be over 100 and not more than 1000//
        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int DailyRate { get; set; }
        //This is the FuelType field//
        //The fuel type has a validation blocks users from entering special character and numbers and has the stringlenght of 25//
      
        [Required]
        public FuelType FuelType { get; set; }
        //This is the IsAvailable field//
        //the IsAvailable show the avtivety of the vehicle//

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Please enter vaild activety from (UnAvaliable,Avaliable and Busy)")]
        [Required]
        [StringLength(13)]
        public string IsAvailable { get; set; }


        //This is the parent Fk//
        public Staff Staff { get; set; }

        //This is the parent Fk//
        public Location Location { get; set; }

        //This is the child FK//
        public ICollection<Rental> Rentals { get; set; }
    }
}
