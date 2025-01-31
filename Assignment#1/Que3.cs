using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_RutulManani.Controllers
{
    [Route("api/q3")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        // Objective: Get the cube of a number
        // GET : localhost:xx/api/q3/cube/4 -> 64
        [HttpGet("cube/{baseNumber}")]
        public int GetCube(int baseNumber)
        {
            return baseNumber * baseNumber * baseNumber;
        }
    }
}
