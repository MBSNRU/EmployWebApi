using EmployApi.Models;

namespace EmployApi.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployDbContext dbContext;

        public EmployeeRepository(EmployDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteEmployee(int id)
        {
            var emp = dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            dbContext.Employees.Remove(emp);
            dbContext.SaveChanges();
            return true;
        }

        public List<Employee> GetAllEmployees()
        {
            return dbContext.Employees.ToList();
        }

        public bool InsertEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateEmployee(Employee employee)
        {
            var emp = dbContext.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();
            emp.Name = employee.Name;
            emp.Gender = employee.Gender;
            emp.Mobile = employee.Mobile;
            emp.Email = employee.Email;
            emp.Address = employee.Address;
            emp.Salary = employee.Salary;
            emp.Department = employee.Department;
            emp.JoiningYear = employee.JoiningYear;
            emp.CompanyId = employee.CompanyId;
            dbContext.SaveChanges();
            return true;
        }
    }
}
