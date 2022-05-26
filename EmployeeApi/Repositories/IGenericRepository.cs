using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Repositories
{
    public interface IGenericRepository<Tclass, Pkey> where Tclass : class
    {
        IEnumerable<Tclass> GetAll();
        Tclass GetByID(Pkey id);
        void DeleteById(Pkey id);
    }
}
