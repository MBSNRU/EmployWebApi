using EmployApi.Models;

namespace EmployApi.Repositories
{
    public interface ICompanyRepository
    {
        List<Company> GetAllCompanies();
        bool InsertCompany(Company company);
        bool UpdateCompany(Company company);
        bool DeleteCompany(int id);
    }
}
