using EmployeeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Data
{
    public class ApplicationContext : DbContext
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public ApplicationContext(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionProvider.GetDbConnection().ConnectionString);
        }
    }
}
