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
        /// <returns>TemperatureResponse.</returns>
        TemperatureResponse ConvertTemperature(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo);

        /// <summary>
        /// Converts and adds or subtracts temperature values given in different units.
        /// </summary>
        /// <param name="firstValue">First value.</param>
        /// <param name="firstUnit">First units.</param>
        /// <param name="operation">Type of operation.</param>
        /// <param name="secondValue">Second Value.</param>
        /// <param name="secondUnit">Second units.</param>
        /// <returns>ResultsInBothUnits.</returns>
        ResultInBothUnits AddTemperature(double firstValue, TemperatureUnits firstUnit, Operations operation, double secondValue, TemperatureUnits secondUnit);
    }
}
