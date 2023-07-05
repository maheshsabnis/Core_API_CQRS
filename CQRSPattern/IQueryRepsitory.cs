using Core_API_CQRS.Models;

namespace Core_API_CQRS.CQRSPattern
{
    public interface IDepartmentQueriesRepository
    {
        Task<IEnumerable<Department>> GetDepartmentsAsync();
        Task<Department> GetByDeptNoAsync(int dno);
    }
}
