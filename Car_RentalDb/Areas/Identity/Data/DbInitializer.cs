using Car_RentalDb.Models;
using Microsoft.CodeAnalysis.Elfie.Serialization;

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
                 new Customer {Name= "Mary", LastName= "Willam",Email= "Mary.Willam@gmail.com", Address= "123 Main Street Auckland 1010 New Zealand",PhoneNumber= 02127329032,identitfication= "Yes"},
                 new Customer {Name= "John", LastName= "Smith",Email= "Mary.Willam@gmail.com", Address= "456 New North Road, Kingsland, Auckland, 1021",PhoneNumber= 0280123456,identitfication= "No"},
                 new Customer {Name= "Emily", LastName= "Jones",Email= "Mary.Willam@gmail.com", Address= "789 Dominion Road, Mt Eden, Auckland, 1024",PhoneNumber= 0211234567,identitfication= "Yes"},
                 new Customer {Name= "Michael", LastName= "Brown",Email= "Mary.Willam@gmail.com", Address= "101 Ponsonby Road, Ponsonby, Auckland, 1011",PhoneNumber=0222345678,identitfication= "Yes"},
                 new Customer {Name= "Sophia", LastName= "Davis",Email= "Mary.Willam@gmail.com", Address= "202 Great North Road, Grey Lynn, Auckland, 1021",PhoneNumber= 0203456789,identitfication= "Yes"},
                 new Customer {Name= "Daniel", LastName= "Miller",Email= "Mary.Willam@gmail.com", Address= "303 K Road, Newton, Auckland, 1010",PhoneNumber=0274567890,identitfication= "No"},
                 new Customer {Name= "Olivia", LastName= "Wilson",Email= "Mary.Willam@gmail.com", Address= "404 Remuera Road, Remuera, Auckland, 1050",PhoneNumber= 0255678901,identitfication= "Yes"},
                 new Customer {Name= "Christopher", LastName= "Moore",Email= "Mary.Willam@gmail.com", Address= "505 Beach Road, Mission Bay, Auckland, 1071",PhoneNumber=0296789012,identitfication= "No"},
                 new Customer {Name= "Ava", LastName= "Taylor",Email= "Mary.Willam@gmail.com", Address= "606 Takapuna Road, Takapuna, Auckland, 0622",PhoneNumber= 0237890123,identitfication= ""},
                 new Customer {Name= "William", LastName= "Johnson",Email= "Mary.Willam@gmail.com", Address= "707 Albany Highway, Albany, Auckland, 0632",PhoneNumber= 0248901234,identitfication= "Yes"},

           };
            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();

            var locations = new Location[]
        {
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="789 Dominion Road, Mount Eden, Auckland",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },

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
        };
            foreach (Staff s in staffs)
            {
                context.Staff.Add(s);
            }
            context.SaveChanges();

            var cars = new Car[]
        {
                new Car {StaffID=1,LocationID=1,Model= "Toyota Hiux",Year=2015, DailyRate= 590, FuelType= "Diesel",IsAvailable= "Not Active"},
                new Car {StaffID=2,LocationID=1, Model = "Mazda Demio", Year =2023, DailyRate = 200, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=3, LocationID = 1, Model = "Toyota Aqua", Year = 2016, DailyRate = 154, FuelType = "Petrol", IsAvailable = "Not Active" },
                new Car {StaffID=4,LocationID = 1, Model = "Toyota Vitz", Year =2014, DailyRate = 350, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=5,LocationID=1,Model = "Kia Niro", Year =2016, DailyRate = 480, FuelType = "Petrol", IsAvailable = "Not Active" },
                new Car {StaffID=6, LocationID = 1, Model = "Ford Escape", Year =2014, DailyRate = 781, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=7, LocationID = 1, Model = "Toyota Rav4", Year =2010, DailyRate = 430, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=8, LocationID = 1, Model = "Mitsubishi Triton Canopy", Year =2019, DailyRate = 806, FuelType = "Diesel", IsAvailable = "Not Active" },
                new Car {StaffID=10, LocationID = 1, Model = "Toyota Hiluz", Year =2023, DailyRate = 602, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=11, LocationID = 1, Model = "Holden Trax", Year =2020, DailyRate = 444, FuelType = "Petrol", IsAvailable = "Not Active" },
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
