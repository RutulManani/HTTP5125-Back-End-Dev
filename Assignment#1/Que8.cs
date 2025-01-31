using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_RutulManani.Controllers
{
    [Route("api/q8")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        /// <summary>
        /// Generates a checkout summary for an order of small and large items.
        /// </summary>
        /// <param name="Small">Quantity of small items.</param>
        /// <param name="Large">Quantity of large items.</param>
        /// <returns>Returns a detailed order summary including subtotal, tax, and total.</returns>
        // POST : localhost/api/q8/squashfellows {Small=1, Large=1} -> Checkout summary

        [HttpPost("squashfellows")]
        public string SquashFellows(int Small, int Large)
        {
            double smallPrice = 25.50;
            double largePrice = 40.50;
            double subtotal = (Small * smallPrice) + (Large * largePrice);
            double tax = subtotal * 0.13;
            double total = subtotal + tax;

            return $"{Small} Small @ $25.50 = ${Small * smallPrice}; " +
                   $"{Large} Large @ $40.50 = ${Large * largePrice}; " +
                   $"Subtotal = ${subtotal}; Tax = ${Math.Round(tax, 2)} HST; " +
                   $"Total = ${Math.Round(total, 2)}";
        }
    }
}
