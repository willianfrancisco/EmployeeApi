using EmployeeApi.Models;
using EmployeeApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;

        public EmployeeController(IEmployeeRepository employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult GetAllEmployees()
        {
           IEnumerable<Employee> employees =  _employeeService.GetAll();

            if (employees != null)
            {
                return Ok(employees);
            }
            return NotFound("Nenhum Usuario Encontrado");
        }

        [HttpGet("{id}")]
        public ActionResult GetEmployeeById([FromRoute] int id)
        {
            Employee employee = _employeeService.GetByID(id);

            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Não foi encontrado nenhum Empregado com o Id{id}");
        }

        [HttpPost]
        public ActionResult InsertEmployee([FromBody]Employee employee)
        {
            _employeeService.InsertNewEmployee(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { Id = employee.Id }, employee);
        }

        [HttpPut]
        public ActionResult UpdateEmployee([FromBody]Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee([FromRoute]int id)
        {
            _employeeService.DeleteById(id);
            return NoContent();
        }
    }
}
