using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Models
{
    public interface IPrimaryKeyType<PKeyType>
    {
        PKeyType Id { get; set; }
    }
}
