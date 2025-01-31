using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_RutulManani.Controllers
{
    [Route("api/q1/welcome")]
    [ApiController]
    public class Q1Controller : ControllerBase
    {
        // objective : Get a welcome message
        // GET : localhost:xx/api/q1/welcome -> "Welcome to 5125!"

        [HttpGet]
        public string Get()
        {
            return "Welcome to 5125!";
        }
        
    }
}
