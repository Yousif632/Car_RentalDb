using Car_RentalDb.Models;

namespace Car_RentalDb.Areas.Identity.Data
{
    public class DbInitializer
    {
        internal static void Initialize(Car_RentalDbContext context)
        {
            context.Database.EnsureCreated();

            //Look for any customers.
            if (context.Car.Any())
            {
                return; //DB has been seeded

            }

            var customers = new Customer[]
           {
                new Customer {Name= "Mary", LastName= "Willam",Email= "Mary.Willam@gmail.com", Address= "123 Main Street Auckland 1010 New Zealand",PhoneNumber= 02127329032,identitfication= "Yes"}
           };
            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();

            var locations = new Location[]
        {
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours= "9am",ClosingHours= "6pm" }
        };
            foreach (Location l in locations)
            {
                context.Location.Add(l);
            }
            context.SaveChanges();

            var staffs = new Staff[]
        {
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "789 Albert Street Auckland"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "123 Main Street, Auckland"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "456 Elm Avenue, Auckland"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "789 Oak Road, Auckland"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "101 Pine Lane, Auckland"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "246 Maple Street, Auckland"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "802 Cedar Road, Auckland 1081"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "555 Walnut Lane, Auckland "},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "777 Spruce Street, Auckland 1101"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "888 Sycamore Avenue, Auckland 1110"},
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Yes",Address= "222 Willow Way, Auckland 1120"},
        };
            foreach (Staff s in staffs)
            {
                context.Staff.Add(s);
            }
            context.SaveChanges();

            var cars = new Car[]
        {
                new Car {StaffID=1,LocationID=1,Model= "Toyota Hiux",Year= 2015, DailyRate= 590, FuelType= "Diesel",IsAvailable= "No"}
        };
            foreach (Car c in cars)
            {
                context.Car.Add(c);
            }
            context.SaveChanges();

            var rentals = new Rental[]
  {
                new Rental {CarID=1,CustomerID=1,}
  };
            foreach (Rental r in rentals)
            {
                context.Rental.Add(r);
            }


        }
    }
}
