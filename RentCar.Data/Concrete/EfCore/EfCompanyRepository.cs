using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Data.Concrete.EfCore
{
    public class EfCompanyRepository : EfGenericRepository<Company>, ICompanyRepository
    {

        public EfCompanyRepository(RentCarContext context) : base(context)
        {

        }
        public RentCarContext RContext
        {
            get { return context as RentCarContext; }
        }
    }

}
