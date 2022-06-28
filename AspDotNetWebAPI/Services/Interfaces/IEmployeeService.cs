using AspDotNetWebAPI.Models;

namespace AspDotNetWebAPI.Services.Interfaces

{
    public interface IEmployeeService
    {
        //CREATE
        void CreateEmployee(Employee employee);

        //READ
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetEmployees();

        //UPDATE
        void UpdateEmployee(Employee employee);

        //DELETE
        bool DeleteEmployee(int id);
    }
}
