using Core_API_CQRS.Models;

namespace Core_API_CQRS.CQRSPattern
{
    public class DepartmentCommandRepository : IDepartmentCommandRepository
    {
        BajajCompanyContext ctx;

        public DepartmentCommandRepository(BajajCompanyContext ctx)
        {
            this.ctx = ctx;
        }

        async Task<Department> IDepartmentCommandRepository.SaveDepartmentAsync(Department dept)
        {
            var result = await ctx.Departments.AddAsync(dept);
            await ctx.SaveChangesAsync();
            return result.Entity;
        }
    }
}
