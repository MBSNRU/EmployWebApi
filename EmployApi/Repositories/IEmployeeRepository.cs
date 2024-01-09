using EmployApi.Models;

namespace EmployApi.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
        bool InsertEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(int id);
    }
}
