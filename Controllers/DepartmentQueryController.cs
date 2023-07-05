using Core_API_CQRS.CQRSPattern;
using Core_API_CQRS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API_CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartentQueryController : ControllerBase
    {
        IDepartmentQueriesRepository _queryRepo;

        public DepartentQueryController( IDepartmentQueriesRepository queryRepo)
        {
             
            _queryRepo = queryRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id) 
        {
            var response = await _queryRepo.GetByDeptNoAsync(id);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var response = await _queryRepo.GetDepartmentsAsync();
            return Ok(response);
        }
    }
}
