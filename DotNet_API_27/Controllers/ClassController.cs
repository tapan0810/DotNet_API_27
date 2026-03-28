using DotNet_API_27.Entities.DTOs.ClassDTO;
using DotNet_API_27.Service;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_API_27.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _service;

        public ClassController(IClassService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _service.GetById(id);
            if (data == null) return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateClassDTO dto)
            => Ok(await _service.Create(dto));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateClassDTO dto)
            => Ok(await _service.Update(id, dto));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
            => Ok(await _service.Delete(id));
    }
}