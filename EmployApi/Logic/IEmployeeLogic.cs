using EmployApi.Models;

namespace EmployApi.Logic
{
    public interface IEmployeeLogic
    {
        List<Employee> GetAllEmployees();
        bool InsertEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(int id);
    }
}
