using Core_API_CQRS.Models;

namespace Core_API_CQRS.CQRSPattern
{
    public interface IDepartmentCommandRepository
    {
        Task<Department> SaveDepartmentAsync(Department dept);
    }


    
}
