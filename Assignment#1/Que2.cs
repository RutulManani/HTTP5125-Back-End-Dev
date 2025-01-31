using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_RutulManani.Controllers
{
    [Route("api/q2")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        // Objective: Get a greeting message
        // GET : localhost:xx/api/q2/greeting?name=Gary -> "Hi Gary!"
        [HttpGet("greeting")]
        public string Get(string name)
        {
            return $"Hi {name}!";
        }
    }
}
