using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int CarID{ get; set; }
        public int CustomerID { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime Start_Date { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "End date is required")]
        public DateTime End_Date { get; set; }

        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int Booking_Rate { get; set; }
        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int Insurance_Charge { get; set; }
        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int Fuel_Charge { get; set; }

        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}
