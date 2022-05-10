using UnitConvertersService.Models;

namespace UnitConvertersService.Services
{
    public interface ITemperatureService
    {
        /// <summary>
        /// Converts units of temperature.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="UnitsFrom">Source units.</param>
        /// <param name="UnitsTo">Target units.</param>
        /// <returns>Double.</returns>
        double ConvertTemperature(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo);
    }
}
