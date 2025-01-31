using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_RutulManani.Controllers
{
    [Route("api/q7")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Adjusts the current date by the specified number of days.
        /// </summary>
        /// <param name="days">Number of days to add (positive) or subtract (negative) from today.</param>
        /// <returns>Returns the adjusted date in YYYY-MM-DD format.</returns>
        // GET : localhost:xx/api/q7/timemachine?days=1 -> "YYYY-MM-DD"

        [HttpGet("timemachine")]
        public string GetTimeMachine(int days)
        {
            var adjustedDate = DateTime.Today.AddDays(days).ToString("yyyy-MM-dd");
            return adjustedDate;
        }
    }
}
