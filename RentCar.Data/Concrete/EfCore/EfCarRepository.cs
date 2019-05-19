using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentCar.Data.Concrete.EfCore
{
    public class EfCarRepository : EfGenericRepository<Car>, ICarRepository
    {

        public EfCarRepository(RentCarContext context) : base(context)
        {

        }
        public RentCarContext RContext
        {
            get { return context as RentCarContext; }
        }

        
    }
}
