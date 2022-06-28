using AspDotNetWebAPI.Models;
using AspDotNetWebAPI.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AspDotNetWebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees;
        public EmployeeService()
        {
            _employees = new List<Employee>()
            {
                new Employee() 
                { 
                    Id = 1, 
                    Name = "Sakthi", 
                    Email = "sakthi@gmail.com", 
                    Role = "Dot Net",
                    Salary = 20000
                },
                new Employee() 
                { 
                    Id = 2, 
                    Name = "Maheshwar", 
                    Email = "maheshwar@gmail.com", 
                    Role = "Software Testing",
                    Salary = 21000
                }            
            };
        }

        //CREATE
        public void CreateEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        //READ
        public Employee GetEmployee(int id)
        {
            return _employees.Where(x => x.Id == id).FirstOrDefault();
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return _employees;
        }
               
        //UPDATE
        public void UpdateEmployee(Employee employee)
        {
            var originalEmployee = GetEmployee(employee.Id);
                      
            if (originalEmployee != null)
            {
                _employees.ForEach(items =>
                {
                    if (items.Id == employee.Id)
                    {
                        items.Name = employee.Name;
                    }
                });
            }
            else
            {
                _employees.Add(employee);
            }
        }

        //DELETE
        public bool DeleteEmployee(int id)
        {
            _employees = _employees.Where(x => x.Id != id).ToList();
            return true;
        }
    }
}
