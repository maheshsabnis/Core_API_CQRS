using Core_API_CQRS.CQRSPattern;
using Core_API_CQRS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_API_CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentCommandController : ControllerBase
    {
        private readonly IDepartmentCommandRepository _commandRepo;

        public DepartmentCommandController(IDepartmentCommandRepository repository)
        {
            _commandRepo = repository;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Department dept)
        {
            var response = await _commandRepo.SaveDepartmentAsync(dept);
            return Ok(response);
        }
    }
}
