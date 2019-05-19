using Microsoft.EntityFrameworkCore;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Data.Concrete.EfCore
{
    public class RentCarContext : DbContext
    {
        public RentCarContext(DbContextOptions<RentCarContext> options)
          : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SE862OL;Database=RentACar;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ForRent> ForRents { get; set; }
        public DbSet<Worker> Workers { get; set; }
    

}
}
