namespace Car_RentalDb.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public int StaffId { get; set; }
        public int LocationId { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int DailyRate { get; set; }
        public string FuelType { get; set; }
        public string IsAvailable { get; set; }


        public Staff Staffs { get; set; }
        public Location Locations { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
