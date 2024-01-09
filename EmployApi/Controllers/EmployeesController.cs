using EmployApi.Logic;
using EmployApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        /*private readonly EmployDbContext dbContext;


        public EmployeesController(EmployDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
            return dbContext.Employees.ToList();
        }

        [HttpPost]

        public bool InsertEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return true;
        }

        [HttpPut]
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

        [HttpDelete]
        public bool DeleteEmployee(int id)
        {
            var emp = dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            dbContext.Employees.Remove(emp);
            dbContext.SaveChanges();
            return true;
        }
        */



        private readonly IEmployeeLogic employeeLogic;

        public EmployeesController(IEmployeeLogic employeeLogic)
        {
            this.employeeLogic = employeeLogic;
        }

        [HttpGet]
        public List<Employee> GetAllEmployees()
        {
           return employeeLogic.GetAllEmployees();
        }

        [HttpPost]

        public bool InsertEmployee(Employee employee)
        {
           return employeeLogic.InsertEmployee(employee);
        }

        [HttpPut]
        public bool UpdateEmployee(Employee employee)
        {
           return employeeLogic.UpdateEmployee(employee);
        }

        [HttpDelete]
        public bool DeleteEmployee(int id)
        {
           return employeeLogic.DeleteEmployee(id);
        }





    }
}
