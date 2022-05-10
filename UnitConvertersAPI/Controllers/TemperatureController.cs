using Microsoft.AspNetCore.Mvc;
using UnitConvertersService.Models;
using UnitConvertersService.Services;

namespace UnitConvertersAPI.Controllers
{
    [ApiController]
    [Route("Temperature/[controller]")]
    public class TemperatureController : ControllerBase
    {
        private readonly ITemperatureService _temperatureService;
        public TemperatureController(ITemperatureService temperatureService)
        {
            _temperatureService = temperatureService;
        }

        /// <summary>
        /// Converts units of temperature.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="UnitsFrom">Source units.</param>
        /// <param name="UnitsTo">Target units.</param>
        /// <returns>Double.</returns>
        [HttpPost("/ConvertTemperature", Name = "ConvertTemperature")]
        public async Task<IActionResult> ConvertTemperature(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo)
        {
            return Ok(_temperatureService.ConvertTemperature(value, UnitsFrom, UnitsTo));
        }
    }
}
