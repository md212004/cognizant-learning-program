using Microsoft.AspNetCore.Mvc;
using Assignment4WebAPI.Models;

namespace Assignment4WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        //  Hardcoded employee list
        private static List<Employee> employees = new List<Employee>
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

        //  GET: All employees
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            return Ok(employees);
        }

        //  GET: Employee by ID
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound($"Employee with ID {id} not found.");
            }
            return Ok(employee);
        }

        //  POST: Add new employee
        [HttpPost]
        public ActionResult<Employee> AddEmployee([FromBody] Employee newEmployee)
        {
            if (newEmployee.Id <= 0)
            {
                return BadRequest("Invalid employee ID.");
            }
            if (employees.Any(e => e.Id == newEmployee.Id))
            {
                return BadRequest($"Employee with ID {newEmployee.Id} already exists.");
            }
            employees.Add(newEmployee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = newEmployee.Id }, newEmployee);
        }

        //  PUT: Update employee
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee ID.");
            }
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
            {
                return NotFound($"Employee with ID {id} not found.");
            }

            // Update fields
            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Salary = updatedEmployee.Salary;
            existingEmployee.Permanent = updatedEmployee.Permanent;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Skills = updatedEmployee.Skills;
            existingEmployee.DateOfBirth = updatedEmployee.DateOfBirth;

            return Ok(existingEmployee);
        }

        //  DELETE: Remove employee
        [HttpDelete("{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            var employeeToDelete = employees.FirstOrDefault(e => e.Id == id);
            if (employeeToDelete == null)
            {
                return NotFound($"Employee with ID {id} not found.");
            }
            employees.Remove(employeeToDelete);
            return Ok($"Employee with ID {id} deleted successfully.");
        }
    }
}
