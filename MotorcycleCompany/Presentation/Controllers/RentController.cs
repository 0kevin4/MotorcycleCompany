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
    public class RentController : ControllerBase
    {
        private readonly IServiceManager _service;

        public RentController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetMotorcycles()
        {
            var Rents = _service.RentService.GetAllRents(trackChanges: false);
            return Ok(Rents);
        }
    }
}
