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
        public string Model { get; set; }
        //This is the year field//
        public int Year { get; set; }
        //This is the DailyRate field//
        public int DailyRate { get; set; }
        //This is the FuelType field//
        public string FuelType { get; set; }
        //This is the IsAvailable field//
        public string IsAvailable { get; set; }

        //This is the Fk//
        public Staff Staff { get; set; }
        public Location Location { get; set; }
        public ICollection<Rental> Rentals { get; set; }
    }
}
