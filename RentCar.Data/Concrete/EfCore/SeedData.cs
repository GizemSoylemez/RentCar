using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RentCar.Data.Concrete.EfCore
{
    public class SeedData
    {
       /* public static void EnsurePopulated(IApplicationBuilder app)
        {

            var context = app.ApplicationServices.GetRequiredService<RentCarContext>();
            context.Database.Migrate();
            if (!context.Cars.Any())
            {
                var cars = new[] {
          new Car(){CarName="Mini-cooper"},
          new Car(){CarName="Porche"},
          new Car(){CarName="Ford"}
        };

                context.Cars.AddRange(cars);

                var Cars = new[] {
          new Car(){CarName="mini-cooper",CarModel="Model",Price=45555,InputDate=DateTime.Now,OutputDate=DateTime.Now}
        };
                context.Cars.AddRange(Cars);
                context.SaveChanges();
            }

        }*/
    }
}
