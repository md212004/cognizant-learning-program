using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John Doe",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET Core" }
                    },
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 2, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Java" },
                        new Skill { Id = 4, Name = "Angular" }
                    },
                    DateOfBirth = new DateTime(1992, 5, 23)
                }
            };
        }

        // GET: Return all employees (with test exception)
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        [ProducesResponseType(500)]
        public ActionResult<List<Employee>> GetEmployees()
        {
            // Throw an exception for testing custom exception filter
           throw new Exception("This is a test exception from GetEmployees");

            // return Ok(employees); //Commented out because we throw an error
        }

        // POST: Add new employee
        [HttpPost]
        public ActionResult<Employee> AddEmployee([FromBody] Employee newEmployee)
        {
            employees.Add(newEmployee);
            return CreatedAtAction(nameof(GetEmployees), new { id = newEmployee.Id }, newEmployee);
        }

        // PUT: Update an existing employee
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            // Find employee by id
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update employee details
            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Salary = updatedEmployee.Salary;
            existingEmployee.Permanent = updatedEmployee.Permanent;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Skills = updatedEmployee.Skills;
            existingEmployee.DateOfBirth = updatedEmployee.DateOfBirth;

            return Ok(existingEmployee); // Return updated employee
        }
        // POST: Add a new employee
        [HttpPost]
        public ActionResult<Employee> CreateEmployee([FromBody] Employee newEmployee)
        {
            if (newEmployee.Id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            // Check if ID already exists
            if (employees.Any(e => e.Id == newEmployee.Id))
            {
                return BadRequest("Employee with this id already exists");
            }

            employees.Add(newEmployee);
            return CreatedAtAction(nameof(GetEmployees), new { id = newEmployee.Id }, newEmployee);
        }

        // DELETE: Remove an employee by ID
        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var employeeToDelete = employees.FirstOrDefault(e => e.Id == id);

            if (employeeToDelete == null)
            {
                return NotFound("Employee not found");
            }

            employees.Remove(employeeToDelete);
            return Ok($"Employee with id {id} deleted successfully");
        }

    }
}
