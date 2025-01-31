using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_RutulManani.Controllers
{
    [Route("api/q6")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Calculates the area of a regular hexagon given the side length.
        /// </summary>
        /// <param name="side">Length of one side of the hexagon.</param>
        /// <returns>Returns the area of the hexagon.</returns>
        // GET : localhost:xx/api/q6/hexagon?side=1 -> 2.598076211353316

        [HttpGet("hexagon")]
        public double GetHexagonArea(double side)
        {
            return 3 * Math.Sqrt(3) / 2 * Math.Pow(side, 2);
        }
    }
}
