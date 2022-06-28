using AspDotNetWebAPI.Models;
using AspDotNetWebAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetWebAPI.Controllers
{
    [Route("Employee")]
    
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        //CREATE
        [HttpPost("Create")]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            _employeeService.CreateEmployee(employee);
            return new JsonResult("Employee created successfully");
        }

        //READ
        [HttpGet("GetEmployee/{id}")]
        public IActionResult GetEmployees([FromRoute] int id)
        {
            return new JsonResult(_employeeService.GetEmployee(id));
        }
        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees()
        {
            return new JsonResult(_employeeService.GetEmployees());
        }

        //UPDATE
        [HttpPut("Update")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return new JsonResult("Employee updated successfully");
        }

        //DELETE
        [HttpDelete("Delete")]
        public IActionResult DeleteEmployee([FromQuery] int id)
        {
            
            return new JsonResult(_employeeService.DeleteEmployee(id));
        }
    }
}
