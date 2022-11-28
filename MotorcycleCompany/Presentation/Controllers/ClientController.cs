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
    public class ClientController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ClientController(IServiceManager service) =>
            _service = service;

        [HttpGet]
        public IActionResult GetAgencias()
        {
            try
            {
                var Clients = _service.ClientService.GetAllClients(trackChanges: false);
                return Ok(Clients);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
