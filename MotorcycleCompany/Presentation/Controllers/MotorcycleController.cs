using Microsoft.AspNetCore.Mvc;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcycleController : ControllerBase
    {
        private readonly IServiceManager _service;

        public MotorcycleController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetMotorcycles()
        {
            var motorcycles = _service.MotorcycleService.GetAllMotorcycles(trackChanges: false);
            return Ok(motorcycles);

        }
    }
}
