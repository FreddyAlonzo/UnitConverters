using UnitConvertersService.Models;

namespace UnitConvertersService.Services
{
    public interface IWeightService
    {
        /// <summary>
        /// Converts units of weight.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="UnitsFrom">Source units.</param>
        /// <param name="UnitsTo">Target units.</param>
        /// <returns>WeightResponse.</returns>
        WeightResponse ConvertWeight(double value, WeightUnits UnitsFrom, WeightUnits UnitsTo);

        /// <summary>
        /// Converts and adds or subtracts weight values given in different units.
        /// </summary>
        /// <param name="firstValue">First value.</param>
        /// <param name="firstUnit">First units.</param>
        /// <param name="operation">Type of operation.</param>
        /// <param name="secondValue">Second Value.</param>
        /// <param name="secondUnit">Second units.</param>
        /// <returns>WeightResultInBothUnits.</returns>
        WeightResultInBothUnits AddWeight(double firstValue, WeightUnits firstUnit, Operations operation, double secondValue, WeightUnits secondUnit);
    }
}
