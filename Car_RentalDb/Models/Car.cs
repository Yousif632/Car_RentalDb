namespace Car_RentalDb.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public int StaffID { get; set; }
        public int LocationID { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int DailyRate { get; set; }
        public string FuelType { get; set; }
        public string IsAvailable { get; set; }


        public Staff Staff { get; set; }
        public Location Location { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
