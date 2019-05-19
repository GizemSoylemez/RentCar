using Microsoft.EntityFrameworkCore;
using RentCar.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RentCar.Data.Concrete.EfCore
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext context;

        public EfGenericRepository(DbContext _context)
        {
            context = _context;
        }

        public void Add(T entity)
        {

            context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}

