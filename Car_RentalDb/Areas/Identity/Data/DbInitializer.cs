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
                new Staff {Name= "Sam",LastName="Anderson",Email="SamAnderson@yahoo.com",Phone=0213768901,Active="Available",Address= "789 Albert Street Auckland"},
                new Staff {Name= "Marcus",LastName="rodriguez",Email="MarcusRodriguez@gmail.com",Phone=0234451976,Active="Available",Address= "123 Main Street, Auckland"},
                new Staff {Name= "Jasmine",LastName="Patel",Email="JasminePatel@gmail.com",Phone=0263447722,Active="Busy",Address= "456 Elm Avenue, Auckland"},
                new Staff {Name= "Nathan",LastName="Carter",Email="NathanCarter@Outlook.com",Phone=0274818456,Active="UnAvailable",Address= "789 Oak Road, Auckland"},
                new Staff {Name= "Olivia",LastName="Nguyen",Email="OliviaNguyen@Outlook.com",Phone=0296142254,Active="Busy",Address= "101 Pine Lane, Auckland"},
                new Staff {Name= "Brandons",LastName="Evans",Email="BrandonsEvans@gmail.com",Phone=0226440852,Active="UnAvailable",Address= "246 Maple Street, Auckland"},
                new Staff {Name= "Sophia",LastName="Martinez",Email="SophiaMartinez@yahoo.com",Phone=0273522576,Active="Available",Address= "802 Cedar Road, Auckland 1081"},
                new Staff {Name= "Liam",LastName="Thompson",Email="LiamThompson@outlook.com",Phone=0235342683,Active="Available",Address= "555 Walnut Lane, Auckland "},
                new Staff {Name= "Isabella",LastName="Rivera",Email="IsabellaRivera@yahoo.com",Phone=0225074434,Active="Available",Address= "777 Spruce Street, Auckland 1101"},
                new Staff {Name= "Ethan",LastName="Jenkins",Email="EthanJenkins@yahoo.com",Phone=0274723458,Active="Busy",Address= "888 Sycamore Avenue, Auckland 1110"},
                new Staff {Name= "Jackson",LastName="Bills",Email="JacksonBills@gmail.com",Phone=0256232574,Active="UnAvailable",Address= "222 Willow Way, Auckland 1120"},
        };
            foreach (Staff s in staffs)
            {
                context.Staff.Add(s);
            }
            context.SaveChanges();

            var cars = new Car[]
        {
                new Car {StaffID=1,LocationID=1,Model= "Toyota Hiux",Year= 2015, DailyRate= 590, FuelType= "Diesel",IsAvailable= "No"}
                new Car {StaffID=1,LocationID=1, Model = "Mazda Demio", Year = 2010 - 2023, DailyRate = 200, FuelType = "Petrol", IsAvailable = "Yes" },
                new Car {StaffID=1, LocationID = 1, Model = "Toyota Aqua", Year = 2005 - 2016, DailyRate = 154, FuelType = "Petrol", IsAvailable = "No" },
                new Car {StaffID=1,LocationID = 1, Model = "Toyota Vitz", Year = 2000 - 2014, DailyRate = 350, FuelType = "Petrol", IsAvailable = "Yes" },
                new Car {StaffID=1,LocationID=1,Model = "Kia Niro", Year = 2016 - 2023, DailyRate = 480, FuelType = "Petrol", IsAvailable = "No" },
                new Car {StaffID=1,LocationID=1, Model = "Mitsubishi Triton", Year = 2011 - 2015, DailyRate = (int)599.98, FuelType = "Diesel", IsAvailable = "Yes" },
                new Car {StaffID=1, LocationID = 1, Model = "Ford Escape", Year = 2005 - 2014, DailyRate = 781, FuelType = "Petrol", IsAvailable = "Yes" },
                new Car {StaffID=1, LocationID = 1, Model = "Toyota Rav4", Year = 2000 - 2010, DailyRate = 430, FuelType = "Petrol", IsAvailable = "Yes" },
                new Car {StaffID=1, LocationID = 1, Model = "Mitsubishi Triton Canopy", Year = 2013 - 2019, DailyRate = 806, FuelType = "Diesel", IsAvailable = "No" },
                new Car {StaffID=1, LocationID = 1, Model = "Toyota Hiluz", Year = 2016 - 2023, DailyRate = 602, FuelType = "Petrol", IsAvailable = "Yes" },
                new Car {StaffID=1, LocationID = 1, Model = "Holden Trax", Year = 2016 - 2020, DailyRate = 444, FuelType = "Petrol", IsAvailable = "No" },
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
