using System.ComponentModel.DataAnnotations;

namespace Car_RentalDb.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }

        [Display(Name = "Start date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/1/2024", "12/31/2024", ErrorMessage = "Invalid date range. It should be only from 2024")]

        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/1/2024", "12/31/2024", ErrorMessage = "Invalid date range. It should be only from 2024")]
        public DateTime EndDate { get; set; }

        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int BookingRate { get; set; }

        [Range(100, 1000)]
        [DataType(DataType.Currency)]
        public int InsuranceCharge { get; set; }

        [Range(0, 350)]
        [DataType(DataType.Currency)]
        public int FuelCharge { get; set; }

        public Car Car { get; set; }

        public Customer Customer { get; set; }
    }
}
