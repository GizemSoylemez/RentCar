using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Cars { get; set; }
        ICompanyRepository Companies { get; set; }
        ICustomerRepository Customers { get; set; }
        IForRentRepository ForRents { get; set; }
        IWorkerRepository Workers { get; set; }

        int SaveChanges();

    }
}
