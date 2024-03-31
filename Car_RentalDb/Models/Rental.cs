namespace Car_RentalDb.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int CarID{ get; set; }
        public int CustomerID { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Booking_Rate { get; set; }
        public int Insurance_Charge { get; set; }
        public int Fuel_Charge { get; set; }

        public Car Car { get; set; }
        public Customer Customer { get; set; }
    }
}
