using RentCar.Data.Abstract;
using RentCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentCar.Business
{
    public class CompanyBusiness : IDisposable
    {
        IUnitOfWork uow;
        public CompanyBusiness(IUnitOfWork _uow)
        {
            uow = _uow;
        }
        public bool InsertCompany(Company entity)
        {
            try
            {
                uow.Companies.Add(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Could not add company" + err.Message);
            }
        }
        public Company UpdateCompany(Company entity)
        {
            try
            {
                uow.Companies.Update(entity);
                uow.SaveChanges();
                return entity;
            }
            catch (Exception err)
            {
                throw new Exception("Company not selected" + err.Message);
            }
        }
        public bool DeleteCompany(Company entity)
        {
            try
            {
                uow.Companies.Delete(entity);
                uow.SaveChanges();
                return true;

            }
            catch (Exception err)
            {
                return false;
                throw new Exception("Company could not be deleted" + err.Message);
            }

        }
        public bool DeleteCompanyById(int Id)
        {
            try
            {
                Company entity = uow.Companies.Get(Id);
                uow.Companies.Delete(entity);
                uow.SaveChanges();
                return true;
            }
            catch (Exception err)
            {

                return false;
                throw new Exception("Company could not be deleted" + err.Message);
            }
        }
        public List<Company> GetAll()
        {
            try
            {
                return uow.Companies.GetAll().ToList();
            }
            catch (Exception err)
            {
                throw new Exception("Company could not be listed" + err.Message);
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

