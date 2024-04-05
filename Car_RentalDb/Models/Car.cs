﻿using System.ComponentModel.DataAnnotations;

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
        //This validation blocks people from entering special character and numbers and has the stringlenght of 25//
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(25)]
        public string Model { get; set; }
        //This is the year field//

        [Display(Name = "Year")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        [StringLength(4)]
        public DateTime Year { get; set; }
        //This is the DailyRate field//
        //The Validation is that daily rate must be over 100 and not more than 1000//
        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int DailyRate { get; set; }
        //This is the FuelType field//
        //The fuel type has a validation blocks people from entering special character and numbers and has the stringlenght of 25//
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(6)]
        public string FuelType { get; set; }
        //This is the IsAvailable field//

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
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
