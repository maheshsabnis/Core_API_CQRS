using Core_API_CQRS.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace Core_API_CQRS.CQRSPattern
{
    public class DepartmentQueryRepository : IDepartmentQueriesRepository
    {
        BajajCompanyContext ctx;

        public DepartmentQueryRepository(BajajCompanyContext ctx)
        {
            this.ctx = ctx;
        }

        async Task<Department> IDepartmentQueriesRepository.GetByDeptNoAsync(int dno)
        {
            return await ctx.Departments.FindAsync(dno);
        }

        async Task<IEnumerable<Department>> IDepartmentQueriesRepository.GetDepartmentsAsync()
        {
            return await ctx.Departments.ToListAsync();
        }
    }


   
}
