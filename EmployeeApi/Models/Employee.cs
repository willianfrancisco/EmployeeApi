using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Models
{
    [Table("EMPLOYEE")]
    public class Employee : IPrimaryKeyType<int>
    {
        [Column("EMPLOYEE_ID")]
        public int Id { get; set; }
        [Column("EMPLOYEE_NAME")]
        public string Nome { get; set; }
        [Column("EMPLOYEE_GENDER")]
        public string Genero { get; set; }
        [Column("EMPLOYEE_DESIGNATION")]
        public string Cargo { get; set; }

    }
}
