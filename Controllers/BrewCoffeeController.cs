using Microsoft.AspNetCore.Mvc;
using ReadyTech.Models;
using System.Globalization;
using ReadyTech.Validation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReadyTech.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BrewCoffeeController : ControllerBase
    {
        // GET: BrewCoffee
        [HttpGet("/brew-coffee")]
        public IActionResult Get()
        {
            bool _isMonthDayMatch = Util.IsMonthDayMatch(DateTime.Now, 4,1);

            if (_isMonthDayMatch)
            {
                return StatusCode(StatusCodes.Status418ImATeapot, String.Empty);
            }

            BrewCoffee brewCoffee = new BrewCoffee();

            brewCoffee.Message = "Your piping hot coffee is ready";
            brewCoffee.Prepared = DateTime.UtcNow.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz", CultureInfo.InvariantCulture);

            return Ok(brewCoffee);
        }


    }
}
