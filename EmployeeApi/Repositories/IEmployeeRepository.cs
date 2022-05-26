using EmployeeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee, int>
    {
        void InsertNewEmployee(Employee employee);
        void UpdateEmployee(Employee updEmployee);
    }
}
