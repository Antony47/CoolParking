using Microsoft.AspNetCore.Mvc;
using CoolParking.BL.Interfaces;

namespace CoolParking.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : Controller
    {
        private IParkingService parkingService;

        public ParkingController(IParkingService parkingService)
        {
            this.parkingService = parkingService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(parkingService);
        }


        [HttpGet("balance")]
        public IActionResult GetBalance()
        {
            return BadRequest();
        }

        [HttpGet("capacity")]
        public IActionResult GetCapacity()
        {
            return BadRequest();
        }


        [HttpGet("freePlaces")]
        public IActionResult GetFreePlaces()
        {
            return BadRequest();
        }
    }
}
