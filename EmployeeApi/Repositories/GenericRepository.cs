using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Repositories
{
    public class GenericRepository<Tclass, PKeyType> : IGenericRepository<Tclass, PKeyType> where Tclass : class, IPrimaryKeyType<PKeyType>, new()
    {
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext context)
        {
            _dbContext = context;
        }

        public void DeleteById(PKeyType id)
        {
            Tclass entity = _dbContext.Set<Tclass>().AsNoTracking().FirstOrDefault(t => t.Id.Equals(id));
            _dbContext.Set<Tclass>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Tclass> GetAll()
        {
            return _dbContext.Set<Tclass>().AsNoTracking().ToList();
        }

        public Tclass GetByID(PKeyType id)
        {
            return _dbContext.Set<Tclass>().AsNoTracking().FirstOrDefault(t => t.Id.Equals(id));
        }

    }
}
