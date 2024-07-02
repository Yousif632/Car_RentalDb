using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }

        [Display(Name = "Start date")]
       
        public DateTime StartDate { get; set; }
        

        [Display(Name = "End date")]

        public DateTime EndDate { get; set; }
        [Display(Name = "Booking Rate")]
        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int BookingRate { get; set; }

        [Display(Name = "Insurance Charge")]
        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int InsuranceCharge { get; set; }

        [Display(Name = "Fuel Charge")]
        [Range(0, 350)]
        [DataType(DataType.Currency)]
        public int FuelCharge { get; set; }

        public Car Car { get; set; }

        public Customer Customer { get; set; }
    }
}
