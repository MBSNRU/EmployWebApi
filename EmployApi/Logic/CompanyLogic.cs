using EmployApi.Models;
using EmployApi.Repositories;

namespace EmployApi.Logic
{
    public class CompanyLogic : ICompanyLogic
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyLogic(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }
        public bool DeleteCompany(int id)
        {
            return companyRepository.DeleteCompany(id);
        }

        public List<Company> GetAllCompanies()
        {
            return companyRepository.GetAllCompanies();
        }

        public bool InsertCompany(Company company)
        {
            return companyRepository.InsertCompany(company);
        }

        public bool UpdateCompany(Company company)
        {
            return companyRepository.UpdateCompany(company);
        }
    }
}
