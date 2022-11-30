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
    public class CityController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CityController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetAgencias()
        {
            var Cities = _service.CityService.GetAllAgencias(trackChanges: false);
            return Ok(Cities);

        }
    }
}
