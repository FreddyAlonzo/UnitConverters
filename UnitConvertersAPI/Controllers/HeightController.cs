using Microsoft.AspNetCore.Mvc;
using UnitConvertersService.Models;
using UnitConvertersService.Services;

namespace UnitConvertersAPI.Controllers
{
    [ApiController]
    [Route("Height/[controller]")]
    public class HeightController : ControllerBase
    {
        private readonly IHeightService _heightService;
        public HeightController(IHeightService heightService)
        {
            _heightService = heightService;
        }

        /// <summary>
        /// Converts height from imperial to metric.
        /// </summary>
        /// <param name="feetValue">Feet value.</param>
        /// <param name="inchesValue">Inches value.</param>
        /// <returns>HeightResponse.</returns>
        [HttpGet("/ConvertHeightToMetric", Name = "ConvertHeightToMetric")]
        public IActionResult ConvertHeightToMetric(decimal feetValue, decimal inchesValue)
        {
            return Ok(_heightService.ConvertHeightToMetric(feetValue, inchesValue));
        }

        /// <summary>
        /// Converts height from metric to imperial.
        /// </summary>
        /// <param name="metersValue">Feet value.</param>
        /// <param name="centimetersValue">Inches value.</param>
        /// <returns>HeightResponse.</returns>
        [HttpGet("/ConvertHeightToImperial", Name = "ConvertHeightToImperial")]
        public IActionResult ConvertHeightToImperial(decimal metersValue, decimal centimetersValue)
        {
            return Ok(_heightService.ConvertHeightToImperial(metersValue, centimetersValue));
        }

        /// <summary>
        /// Adds of subtracts heights in different units (first value is metric, second value is imperial).
        /// </summary>
        /// <param name="metersValue">Meters value.</param>
        /// <param name="centimetersValue">Centimeters value.</param>
        /// <param name="operation">Operation.</param>
        /// <param name="feetValue">Feet value.</param>
        /// <param name="inchesValue">Inches value.</param>
        /// <returns>HeightResultInBothUnits.</returns>
        [HttpGet("/AddHeightMI", Name = "AddHeightMI")]
        public IActionResult AddHeightMI(decimal metersValue, decimal centimetersValue, Operations operations, decimal feetValue, decimal inchesValue)
        {
            return Ok(_heightService.AddHeightMI(metersValue, centimetersValue, operations, feetValue, inchesValue));
        }

        /// <summary>
        /// Adds of subtracts heights in different units (first value is imperial, second value is metric)
        /// </summary>
        /// <param name="feetValue">Feet value.</param>
        /// <param name="inchesValue">Inches value.</param>
        /// <param name="operation">Operation.</param>
        /// <param name="metersValue">Meters value.</param>
        /// <param name="centimetersValue">Centimeters value.</param>
        /// <returns></returns>
        [HttpGet("/AddHeightIM", Name = "AddHeightIM")]
        public IActionResult AddHeightIM(decimal feetValue, decimal inchesValue, Operations operations, decimal metersValue, decimal centimetersValue)
        {
            return Ok(_heightService.AddHeightIM(feetValue, inchesValue, operations, metersValue, centimetersValue));
        }
    }
}
