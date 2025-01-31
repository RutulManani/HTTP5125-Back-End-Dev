using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_RutulManani.Controllers
{
    [Route("api/q4")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        // Objective: Return the start of a knock-knock joke
        // POST : localhost:xx/api/q4/knockknock -> "Who’s there?"
        [HttpPost("knockknock")]
        public string KnockKnock()
        {
            return "Who’s there?";
        }
    }
}
