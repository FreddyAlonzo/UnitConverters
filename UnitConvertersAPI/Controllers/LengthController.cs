using Microsoft.AspNetCore.Mvc;
using UnitConvertersService.Models;
using UnitConvertersService.Services;

namespace UnitConvertersAPI.Controllers
{
    [ApiController]
    [Route("Length/[controller]")]
    public class LengthController : ControllerBase
    {
        private readonly ILengthService _lengthtService;
        public LengthController(ILengthService lengthService)
        {
            _lengthtService = lengthService;
        }

        /// <summary>
        /// Converts units of length.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="UnitsFrom">Source units.</param>
        /// <param name="UnitsTo">Target units.</param>
        /// <returns>LengthResponse.</returns>
        [HttpGet("/ConvertLength", Name = "ConvertLength")]
        public IActionResult ConvertLength(double value, LengthUnits UnitsFrom, LengthUnits UnitsTo)
        {
            return Ok(_lengthtService.ConvertLength(value, UnitsFrom, UnitsTo));
        }

        /// <summary>
        /// Converts and adds or subtracts length values given in different units.
        /// </summary>
        /// <param name="firstValue">First value.</param>
        /// <param name="firstUnit">First units.</param>
        /// <param name="operation">Type of operation.</param>
        /// <param name="secondValue">Second Value.</param>
        /// <param name="secondUnit">Second units.</param>
        /// <returns>LengthResultInBothUnits.</returns>
        [HttpGet("/AddLength", Name = "AddLength")]
        public IActionResult AddLength(double firstValue, LengthUnits firstUnit, Operations operation, double secondValue, LengthUnits secondUnit)
        {
            return Ok(_lengthtService.AddLength(firstValue, firstUnit, operation, secondValue, secondUnit));
        }
    }
}
