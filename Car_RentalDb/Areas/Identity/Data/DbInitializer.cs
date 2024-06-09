using Car_RentalDb.Models;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace Car_RentalDb.Areas.Identity.Data
{
    public class DbInitializer
    {
        internal static void Initialize(Car_RentalDbContext context)
        {
            context.Database.EnsureCreated();

            //Look for any cars.
            if (context.Car.Any())
            {
                return; //DB has been seeded

            }

            var customers = new Customer[]
           {
                 new Customer {Name= "Mary", LastName= "Willam",Email= "Mary.Willam@gmail.com", Address= "123 Main Street Auckland 1010 New Zealand",PhoneNumber= 02127329032,identitfication= "Yes"},
                 new Customer {Name= "John", LastName= "Smith",Email= "JohnSmith@outlook.com", Address= "456 New North Road, Kingsland, Auckland, 1021",PhoneNumber= 0280123456,identitfication= "No"},
                 new Customer {Name= "Emily", LastName= "Jones",Email= "EmilyJones@gmail.com", Address= "789 Dominion Road, Mt Eden, Auckland, 1024",PhoneNumber= 0211234567,identitfication= "Yes"},
                 new Customer {Name= "Michael", LastName= "Brown",Email= "MichaelBrown@gmail.com", Address= "101 Ponsonby Road, Ponsonby, Auckland, 1011",PhoneNumber=0222345678,identitfication= "Yes"},
                 new Customer {Name= "Sophia", LastName= "Davis",Email= "SophiaDavis@yahoo.com", Address= "202 Great North Road, Grey Lynn, Auckland, 1021",PhoneNumber= 0203456789,identitfication= "Yes"},
                 new Customer {Name= "Daniel", LastName= "Miller",Email= "DanielMiller@outlook.com", Address= "303 K Road, Newton, Auckland, 1010",PhoneNumber=0274567890,identitfication= "No"},
                 new Customer {Name= "Olivia", LastName= "Wilson",Email= "Oliviaillson@gmail.com", Address= "404 Remuera Road, Remuera, Auckland, 1050",PhoneNumber= 0255678901,identitfication= "Yes"},
                 new Customer {Name= "Christ", LastName= "Moore",Email= "ChristMoore@yahoo.com", Address= "505 Beach Road, Mission Bay, Auckland, 1071",PhoneNumber=0296789012,identitfication= "No"},
                 new Customer {Name= "Ava", LastName= "Taylor",Email= "AvaTaylor@gmail.com", Address= "606 Takapuna Road, Takapuna, Auckland, 0622",PhoneNumber= 0237890123,identitfication= "No"},
                 new Customer {Name= "William", LastName= "Johnson",Email= "WilliamJohnson@gmail.com", Address= "707 Albany Highway, Albany, Auckland, 0632",PhoneNumber= 0248901234,identitfication= "Yes"},

           };

            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();

            var locations = new Location[]
        {
                new Location {Address="789 Dominion Road, Mount Eden",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:00am"),ClosingHours=DateTime.Parse("6:00pm") },
                new Location {Address="22 Jellicoe Street, Wynyard Quarter",City= "Auckland",Zip=1030,Country="New Zealand",OpeningHours=DateTime.Parse( "8:00am"),ClosingHours=DateTime.Parse("3:30pm") },
                new Location {Address="56 Federal Street, Auckland Central",City= "Auckland",Zip=1021,Country="New Zealand",OpeningHours=DateTime.Parse( "10:45am"),ClosingHours=DateTime.Parse("2:00pm") },
                new Location {Address="74 Shortland Street,Auckland Central ",City= "Auckland",Zip=1021,Country="New Zealand",OpeningHours=DateTime.Parse( "7:30am"),ClosingHours=DateTime.Parse("5:30pm") },
                new Location {Address="9 City Road, Grafton,Auckland Central ",City= "Auckland",Zip=1020,Country="New Zealand",OpeningHours=DateTime.Parse( "11:00am"),ClosingHours=DateTime.Parse("7:45pm") },
                new Location {Address="12 Victoria Street West, Auckland Central",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "7:00am"),ClosingHours=DateTime.Parse("6:30pm") },
                new Location {Address="45-51 Hobson Street, Auckland Central",City= "Auckland",Zip=1041,Country="New Zealand",OpeningHours=DateTime.Parse( "9:45am"),ClosingHours=DateTime.Parse("6:30pm") },
                new Location {Address="30 Beach Road, Auckland Central",City= "Auckland",Zip=1031,Country="New Zealand",OpeningHours=DateTime.Parse( "6:25am"),ClosingHours=DateTime.Parse("1:40pm") },
                new Location {Address="2 Kitchener Street, Auckland Central",City= "Auckland",Zip=1022,Country="New Zealand",OpeningHours=DateTime.Parse( "9:35am"),ClosingHours=DateTime.Parse("5:00pm") },
                new Location {Address="8 Commerce Street, Auckland Central",City= "Auckland",Zip=1050,Country="New Zealand",OpeningHours=DateTime.Parse( "10:30am"),ClosingHours=DateTime.Parse("4:30pm") },

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
                new Car {StaffID=2,LocationID=2, Model = "Mazda Demio", Year =2023, DailyRate = 200, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=3, LocationID = 3, Model = "Toyota Aqua", Year = 2016, DailyRate = 154, FuelType = "Petrol", IsAvailable = "Not Active" },
                new Car {StaffID=4,LocationID = 4, Model = "Toyota Vitz", Year =2014, DailyRate = 350, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=5,LocationID=5 ,Model = "Kia Niro", Year =2016, DailyRate = 480, FuelType = "Petrol", IsAvailable = "Not Active" },
                new Car {StaffID=6, LocationID = 6, Model = "Ford Escape", Year =2014, DailyRate = 781, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=7, LocationID = 7, Model = "Toyota Rav4", Year =2010, DailyRate = 430, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=8, LocationID = 8, Model = "Mitsubishi Triton Canopy", Year =2019, DailyRate = 806, FuelType = "Diesel", IsAvailable = "Not Active" },
                new Car {StaffID=9, LocationID = 9, Model = "Toyota Hiluz", Year =2023, DailyRate = 602, FuelType = "Petrol", IsAvailable = "Active" },
                new Car {StaffID=10, LocationID = 10, Model = "Holden Trax", Year =2020, DailyRate = 444, FuelType = "Petrol", IsAvailable = "Not Active" },
        };
            foreach (Car c in cars)
            {
                context.Car.Add(c);
            }
            context.SaveChanges();

            var rentals = new Rental[]
  {
                new Rental {CarID=1,CustomerID=1,StartDate=DateTime.Parse( "2023-02-20"),EndDate=DateTime.Parse( "2023-02-25"),BookingRate = 450,InsuranceCharge=235,FuelCharge=183 },
                new Rental {CarID=2,CustomerID=2,StartDate=DateTime.Parse( "2023-06-15"),EndDate=DateTime.Parse( "2023-06-17"),BookingRate = 150,InsuranceCharge=178,FuelCharge=230 },
                new Rental {CarID=3,CustomerID=3,StartDate=DateTime.Parse( "2024-08-07"),EndDate=DateTime.Parse( "2024-08-10"),BookingRate = 550,InsuranceCharge=190,FuelCharge=160},
                new Rental {CarID=4,CustomerID=4,StartDate=DateTime.Parse( "2024-10-22"),EndDate=DateTime.Parse( "2024-10-25"),BookingRate = 230,InsuranceCharge=170,FuelCharge=78},
                new Rental {CarID=5,CustomerID=5,StartDate=DateTime.Parse( "2023-01-05"),EndDate=DateTime.Parse( "2023-02-06"),BookingRate = 390,InsuranceCharge=294,FuelCharge=125 },
                new Rental {CarID=6,CustomerID=6,StartDate=DateTime.Parse( "2024-04-18"),EndDate=DateTime.Parse( "2024-04-27"),BookingRate = 643,InsuranceCharge=465,FuelCharge=144 },
                new Rental {CarID=7,CustomerID=7,StartDate=DateTime.Parse( "2023-06-20"),EndDate=DateTime.Parse( "2023-07-02"),BookingRate = 215,InsuranceCharge=264,FuelCharge=99},
                new Rental {CarID=8,CustomerID=8,StartDate=DateTime.Parse( "2023-09-12"),EndDate=DateTime.Parse( "2023-09-16"),BookingRate = 265,InsuranceCharge=145,FuelCharge=100 },
                new Rental {CarID=9,CustomerID=9,StartDate=DateTime.Parse( "2024-11-25"),EndDate=DateTime.Parse( "2024-12-01"),BookingRate = 415,InsuranceCharge=433,FuelCharge=300},
                new Rental {CarID=10,CustomerID=10,StartDate=DateTime.Parse( "2024-05-20"),EndDate=DateTime.Parse( "2023-05-23"),BookingRate = 250,InsuranceCharge=244,FuelCharge=267 }
  };

            foreach (Rental r in rentals)
            {
                context.Rental.Add(r);
            }

            context.SaveChanges();
        }
    }
}
