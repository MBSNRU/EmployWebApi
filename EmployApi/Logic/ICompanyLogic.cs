using EmployApi.Models;

namespace EmployApi.Logic
{
    public interface ICompanyLogic
    {
        List<Company> GetAllCompanies();
        bool InsertCompany(Company company);
        bool UpdateCompany(Company company);
        bool DeleteCompany(int id);
    }
}
