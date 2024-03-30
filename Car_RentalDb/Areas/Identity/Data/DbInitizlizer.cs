using Car_RentalDb.Models;

namespace Car_RentalDb.Areas.Identity.Data
{
    public class DbInitizlizer
    {
        internal static void Initialize(Car_RentalDbContext context)
        {
            context.Database.EnsureCreated();

            //Look for any customers.
            if (context.Car.Any())
            {
                return; //DB has been seeded

            }
            var cars = new Car[]
          {
                new Car {Model= "Toyota Hiux",Year= 2015, DailyRate= 590, FuelType= "Diesel",IsAvailable= "No"}
          };
            foreach (Car c in cars)
            {
                context.Car.Add(c);
            }
            context.SaveChanges();
        }
    }
}
