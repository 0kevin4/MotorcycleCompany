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
    public class GarageController : ControllerBase
    {
        private readonly IServiceManager _service;

        public GarageController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetGarages()
        {
            try
            {
                var Garages = _service.GarageService.GetAllGarages(trackChanges: false);
                return Ok(Garages);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
