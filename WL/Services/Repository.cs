using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WL.Services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _context;
        private DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Create(T model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose();
        }

        public List<T> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}