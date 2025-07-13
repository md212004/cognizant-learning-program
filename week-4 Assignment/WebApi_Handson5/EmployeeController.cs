using JwtWebApiDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] //  Require JWT token
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John", Salary = 50000, Role = "Admin" },
            new Employee { Id = 2, Name = "Jane", Salary = 60000, Role = "User" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(employees);
        }
    }
}
