using Noriam.SOLID.Model;
using Noriam.SOLID.Services.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Repository.Impl
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal DbContext _context;

        public GenericRepository(DbContext context)
        {
            if (context != null)
                _context = context;
            else
                _context = new ABC_SOLIDEntities();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }
        
    }
}


