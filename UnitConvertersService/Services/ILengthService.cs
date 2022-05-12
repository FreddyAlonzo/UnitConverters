using UnitConvertersService.Models;

namespace UnitConvertersService.Services
{
    public interface ILengthService
    {
        /// <summary>
        /// Converts units of length.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="UnitsFrom">Source units.</param>
        /// <param name="UnitsTo">Target units.</param>
        /// <returns>LengthResponse.</returns>
        LengthResponse ConvertLength(double value, LengthUnits UnitsFrom, LengthUnits UnitsTo);

        /// <summary>
        /// Converts and adds or subtracts length values given in different units.
        /// </summary>
        /// <param name="firstValue">First value.</param>
        /// <param name="firstUnit">First units.</param>
        /// <param name="operation">Type of operation.</param>
        /// <param name="secondValue">Second Value.</param>
        /// <param name="secondUnit">Second units.</param>
        /// <returns>LengthResultInBothUnits.</returns>
        LengthResultInBothUnits AddLength(double firstValue, LengthUnits firstUnit, Operations operation, double secondValue, LengthUnits secondUnit);
    }
}
