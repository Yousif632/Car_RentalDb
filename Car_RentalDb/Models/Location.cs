namespace Car_RentalDb.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
        public string OpeningHours { get; set; }
        public string ClosingHours { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
