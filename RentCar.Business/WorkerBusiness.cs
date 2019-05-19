using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentCar.Business
{
    public class WorkerBusiness
    {
        IUnitOfWork uow;
        public WorkerBusiness(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public bool InsertWorker(Worker entity)
        {
            try
            {
                uow.Workers.Add(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Could not add worker" + err.Message);
            }
        }
        public Worker UpdateWorker(Worker entity)
        {
            try
            {
                uow.Workers.Update(entity);
                uow.SaveChanges();
                return entity;
            }
            catch (Exception err)
            {
                throw new Exception("Worker not selected" + err.Message);
            }
        }
        public bool DeleteWorker(Worker entity)
        {
            try
            {
                uow.Workers.Delete(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Worker could not be deleted" + err.Message);
            }

        }
        public bool DeleteWorkerById(int Id)
        {
            try
            {
                Worker entity = uow.Workers.Get(Id);
                uow.Workers.Delete(entity);
                uow.SaveChanges();
                return true;
            }
            catch (Exception err)
            {

                return false;
                throw new Exception("Worker could not be deleted" + err.Message);
            }
        }
        public List<Worker> GetAll()
        {
            try
            {
                return uow.Workers.GetAll().ToList();
            }
            catch (Exception err)
            {
                throw new Exception("Worker could not be listed" + err.Message);
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
