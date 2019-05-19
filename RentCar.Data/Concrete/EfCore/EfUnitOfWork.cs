using RentCar.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentCar.Data.Concrete.EfCore
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private RentCarContext context;

        public EfUnitOfWork(RentCarContext _context)
        {
            context = _context;
        }

        public ICarRepository _cars;
        public ICompanyRepository _companies;
        public ICustomerRepository _customers;
        public IForRentRepository _forRents;
        public IWorkerRepository _workers;
        public ICarRepository Cars
        {
            get
            {
                return _cars ?? (_cars = new EfCarRepository(context));
            }
        }
        public ICompanyRepository Companies
        {
            get
            {
                return _companies ?? (_companies = new EfCompanyRepository(context));
            }
        }
        public ICustomerRepository Customers
        {
            get
            {
                return _customers ?? (_customers = new EfCustomerRepository(context));
            }
        }
        public IForRentRepository ForRents
        {
            get
            {
                return _forRents ?? (_forRents = new EfForRentRepository(context));
            }
        }
        public IWorkerRepository Workers
        {
            get
            {
                return _workers ?? (_workers = new EfWorkerRepository(context));
            }
        }

        ICarRepository IUnitOfWork.Cars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ICompanyRepository IUnitOfWork.Companies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ICustomerRepository IUnitOfWork.Customers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IForRentRepository IUnitOfWork.ForRents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IWorkerRepository IUnitOfWork.Workers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            context.Dispose();
        }
        public int SaveChanges()
        {
            try
            {
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
