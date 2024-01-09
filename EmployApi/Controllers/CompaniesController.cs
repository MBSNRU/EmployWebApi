using EmployApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly EmployDbContext dbContext;

        //EmployDbContext dbContext = new EmployDbContext();

        public CompaniesController(EmployDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public List<Company> GetAllCompanies()
        {
            return dbContext.Companies.ToList();
        }

        [HttpPost]

        public bool InsertCompany(Company company)
        {
            dbContext.Companies.Add(company);
            dbContext.SaveChanges();
            return true;
        }

        [HttpPut]
        public bool UpdateCompany(Company company)
        {
            var com = dbContext.Companies.Where(x => x.Id == company.Id).FirstOrDefault();
            com.Name = company.Name;
            com.Mobile= company.Mobile;
            com.Email= company.Email;
            com.Address= company.Address;
            com.EstablishedYear= company.EstablishedYear;
            com.ServicesOffered=company.ServicesOffered;
            dbContext.SaveChanges();
            return true;
        }

        [HttpDelete]
        public bool DeleteCompany(int id)
        {
            var com = dbContext.Companies.Where(x=>x.Id==id).FirstOrDefault();
            dbContext.Companies.Remove(com);
            dbContext.SaveChanges() ;
            return true;
        }
        





    }
}
