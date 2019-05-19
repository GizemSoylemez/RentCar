using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Data.Concrete.EfCore
{
    class DesignTimeDbContextFactory:IDesignTimeDbContextFactory<RentCarContext>
    {
        public RentCarContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RentCarContext>();
            return new RentCarContext(builder.Options);
        }
    }
}
