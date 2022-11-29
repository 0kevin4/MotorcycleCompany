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
    public class PhonesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PhonesController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetPhones()
        {
            try
            {
                var phones = _service.PhonesServices.GetAllPhones(trackChanges: false);
                return Ok(phones);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
