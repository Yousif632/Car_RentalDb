using Car_RentalDb.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Car_RentalDb.Models;

namespace Car_RentalDb.Areas.Identity.Data;

public class Car_RentalDbContext : IdentityDbContext<ApplicationUser>
{
    public Car_RentalDbContext(DbContextOptions<Car_RentalDbContext> options)
        : base(options)
    {
    }

public DbSet<Car_RentalDb.Models.Car> Car { get; set; } = default!;

public DbSet<Car_RentalDb.Models.Customer> Customer { get; set; } = default!;


}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(20);
        builder.Property(u => u.LastName).HasMaxLength(20);
    }
}
