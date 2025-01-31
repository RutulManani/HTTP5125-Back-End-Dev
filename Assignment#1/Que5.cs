using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_RutulManani.Controllers
{
    [Route("api/q5")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        // Objective: Return an acknowledgement of the secret integer
        // POST : localhost:xx/api/q5/secret {5} -> "Shh.. the secret is 5"
        [HttpPost("secret")]
        public string Secret(int secret)
        {
            return $"Shh.. the secret is {secret}";
        }
    }
}
