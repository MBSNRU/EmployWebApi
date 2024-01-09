using EmployApi.Models;

namespace EmployApi.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly EmployDbContext dbContext;

        public CompanyRepository(EmployDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteCompany(int id)
        {
            var com = dbContext.Companies.Where(x => x.Id == id).FirstOrDefault();
            dbContext.Companies.Remove(com);
            dbContext.SaveChanges();
            return true;
        }

        public List<Company> GetAllCompanies()
        {
            return dbContext.Companies.ToList();
        }

        public bool InsertCompany(Company company)
        {
            dbContext.Companies.Add(company);
            dbContext.SaveChanges();
            return true;
        }

        public bool UpdateCompany(Company company)
        {
            var com = dbContext.Companies.Where(x => x.Id == company.Id).FirstOrDefault();
            com.Name = company.Name;
            com.Mobile = company.Mobile;
            com.Email = company.Email;
            com.Address = company.Address;
            com.EstablishedYear = company.EstablishedYear;
            com.ServicesOffered = company.ServicesOffered;
            dbContext.SaveChanges();
            return true;
        }
    }
}
