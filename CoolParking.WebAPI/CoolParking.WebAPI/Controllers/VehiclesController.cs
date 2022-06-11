using CoolParking.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoolParking.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : Controller
    {
        private IParkingService parkingService;

        public VehiclesController(IParkingService parkingService)
        {
            this.parkingService = parkingService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(parkingService.GetVehicles());
        }

        [HttpGet("id")]
        public IActionResult GetId(string id)
        {
            

            return BadRequest();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok(parkingService.GetVehicles());
        }
    }
}
