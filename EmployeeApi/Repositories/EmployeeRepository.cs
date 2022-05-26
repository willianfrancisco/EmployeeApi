using EmployeeApi.Data;
using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee, int>, IEmployeeRepository
    {
        private readonly ApplicationContext _applicationContext;
        public EmployeeRepository(DbContext context, ApplicationContext applicationContext) : base(context)
        {
            _applicationContext = applicationContext;
        }

        public void InsertNewEmployee(Employee employee)
        {
            _applicationContext.Employee.Add(employee);
            _applicationContext.SaveChanges();
        }

        public void UpdateEmployee(Employee updEmployee)
        {
            _applicationContext.Employee.Update(updEmployee);
            _applicationContext.SaveChanges();
        }
    }
}
