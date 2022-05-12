using Microsoft.AspNetCore.Mvc;
using UnitConvertersService.Models;
using UnitConvertersService.Services;

namespace UnitConvertersAPI.Controllers
{
    [ApiController]
    [Route("Weight/[controller]")]
    public class WeightController : ControllerBase
    {
        private readonly IWeightService _weightService;
        public WeightController(IWeightService weightService)
        {
            _weightService = weightService;
        }

        /// <summary>
        /// Converts units of weight.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="UnitsFrom">Source units.</param>
        /// <param name="UnitsTo">Target units.</param>
        /// <returns>WeightResponse.</returns>
        [HttpGet("/ConvertWeight", Name = "ConvertWeight")]
        public IActionResult ConvertWeight(double value, WeightUnits UnitsFrom, WeightUnits UnitsTo)
        {
            return Ok(_weightService.ConvertWeight(value, UnitsFrom, UnitsTo));
        }

        /// <summary>
        /// Converts and adds or subtracts weight values given in different units.
        /// </summary>
        /// <param name="firstValue">First value.</param>
        /// <param name="firstUnit">First units.</param>
        /// <param name="operation">Type of operation.</param>
        /// <param name="secondValue">Second Value.</param>
        /// <param name="secondUnit">Second units.</param>
        /// <returns>WeightResultInBothUnits.</returns>
        [HttpGet("/AddWeight", Name = "AddWeight")]
        public IActionResult AddWeight(double firstValue, WeightUnits firstUnit, Operations operation, double secondValue, WeightUnits secondUnit)
        {
            return Ok(_weightService.AddWeight(firstValue, firstUnit, operation, secondValue, secondUnit));
        }
    }
}
