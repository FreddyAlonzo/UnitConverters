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
        /// <returns>TemperatureResponse.</returns>
        [HttpGet("/ConvertTemperature", Name = "ConvertTemperature")]
        public IActionResult ConvertTemperature(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo)
        {
            return Ok(_temperatureService.ConvertTemperature(value, UnitsFrom, UnitsTo));
        }

        /// <summary>
        /// Converts and adds or subtracts temperature values given in different units.
        /// </summary>
        /// <param name="firstValue">First value.</param>
        /// <param name="firstUnit">First units.</param>
        /// <param name="operation">Type of operation.</param>
        /// <param name="secondValue">Second Value.</param>
        /// <param name="secondUnit">Second units.</param>
        /// <returns>ResultsInBothUnits.</returns>
        [HttpGet("/AddTemperature", Name = "AddTemperature")]
        public IActionResult AddTemperature(double firstValue, TemperatureUnits firstUnit, Operations operation, double secondValue, TemperatureUnits secondUnit)
        {
            return Ok(_temperatureService.AddTemperature(firstValue, firstUnit, operation, secondValue, secondUnit));
        }
    }
}
