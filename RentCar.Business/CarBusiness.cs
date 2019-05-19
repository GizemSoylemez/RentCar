using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentCar.Business
{
    public class CarBusiness : IDisposable
    {
        IUnitOfWork uow;
        public CarBusiness(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public bool InsertCar(Car entity)
        {
            try
            {
                uow.Cars.Add(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Could not add car" + err.Message);
            }
        }
        public Car UpdateCar(Car entity)
        {
            try
            {
                uow.Cars.Update(entity);
                uow.SaveChanges();
                return entity;
            }
            catch (Exception err)
            {
                throw new Exception("car not selected" + err.Message);
            }
        }
        public bool DeleteCar(Car entity)
        {
            try
            {
                uow.Cars.Delete(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Car could not be deleted" + err.Message);
            }

        }
        public bool DeleteCarById(int Id)
        {
            try
            {
                Car entity = uow.Cars.Get(Id);
                uow.Cars.Delete(entity);
                uow.SaveChanges();
                return true;
            }
            catch (Exception err)
            {

                return false;
                throw new Exception("Car could not be deleted" + err.Message);
            }
        }
        public List<Car> GetAll()
        {
            try
            {
                return uow.Cars.GetAll().ToList();
            }
            catch (Exception err)
            {
                throw new Exception("Cars could not be listed" + err.Message);
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
