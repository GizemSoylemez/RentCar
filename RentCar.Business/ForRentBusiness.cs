using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentCar.Business
{
    public class ForRentBusiness
    {
        IUnitOfWork uow;
        public ForRentBusiness(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public bool InsertForRent(ForRent entity)
        {
            try
            {
                uow.ForRents.Add(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Could not add for rent" + err.Message);
            }
        }
        public ForRent UpdateForRent(ForRent entity)
        {
            try
            {
                uow.ForRents.Update(entity);
                uow.SaveChanges();
                return entity;
            }
            catch (Exception err)
            {
                throw new Exception("ForRent not selected" + err.Message);
            }
        }
        public bool DeleteForRent(ForRent entity)
        {
            try
            {
                uow.ForRents.Delete(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("forrent could not be deleted" + err.Message);
            }

        }
        public bool DeleteForRentById(int Id)
        {
            try
            {
                ForRent entity = uow.ForRents.Get(Id);
                uow.ForRents.Delete(entity);
                uow.SaveChanges();
                return true;
            }
            catch (Exception err)
            {

                return false;
                throw new Exception("forrent could not be deleted" + err.Message);
            }
        }
        public List<ForRent> GetAll()
        {
            try
            {
                return uow.ForRents.GetAll().ToList();
            }
            catch (Exception err)
            {
                throw new Exception("Forrent could not be listed" + err.Message);
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
