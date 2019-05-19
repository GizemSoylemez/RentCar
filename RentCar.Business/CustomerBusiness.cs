using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentCar.Business
{
    public class CustomerBusiness
    {
        IUnitOfWork uow;
        public CustomerBusiness(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public bool InsertCustomer(Customer entity)
        {
            try
            {
                uow.Customers.Add(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Could not add customer" + err.Message);
            }
        }
        public Customer UpdateCustomer(Customer entity)
        {
            try
            {
                uow.Customers.Update(entity);
                uow.SaveChanges();
                return entity;
            }
            catch (Exception err)
            {
                throw new Exception("customer not selected" + err.Message);
            }
        }
        public bool DeleteCustomer(Customer entity)
        {
            try
            {
                uow.Customers.Delete(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Customer could not be deleted" + err.Message);
            }

        }
        public bool DeleteCustomerById(int Id)
        {
            try
            {
                Customer entity = uow.Customers.Get(Id);
                uow.Customers.Delete(entity);
                uow.SaveChanges();
                return true;
            }
            catch (Exception err)
            {

                return false;
                throw new Exception("Customer could not be deleted" + err.Message);
            }
        }
        public List<Customer> GetAll()
        {
            try
            {
                return uow.Customers.GetAll().ToList();
            }
            catch (Exception err)
            {
                throw new Exception("Customer could not be listed" + err.Message);
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
        public void Save()
        {
            uow.SaveChanges();
        }
    }
}
