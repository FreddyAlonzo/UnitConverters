using UnitConvertersService.Models;

namespace UnitConvertersService.Services
{
    public interface IHeightService
    {
        /// <summary>
        /// Converts height from imperial to metric.
        /// </summary>
        /// <param name="feetValue">Feet value.</param>
        /// <param name="inchesValue">Inches value.</param>
        /// <returns>HeightResponse.</returns>
        HeightResponse ConvertHeightToMetric(decimal feetValue, decimal inchesValue);

        /// <summary>
        /// Converts height from metric to imperial.
        /// </summary>
        /// <param name="metersValue">Feet value.</param>
        /// <param name="centimetersValue">Inches value.</param>
        /// <returns>HeightResponse.</returns>
        HeightResponse ConvertHeightToImperial(decimal metersValue, decimal centimetersValue);

        /// <summary>
        /// Adds of subtracts heights in different units (first value is metric, second value is imperial).
        /// </summary>
        /// <param name="metersValue">Meters value.</param>
        /// <param name="centimetersValue">Centimeters value.</param>
        /// <param name="operation">Operation.</param>
        /// <param name="feetValue">Feet value.</param>
        /// <param name="inchesValue">Inches value.</param>
        /// <returns>HeightResultInBothUnits.</returns>
        HeightResultInBothUnits AddHeightMI(decimal metersValue, decimal centimetersValue, Operations operation, decimal feetValue, decimal inchesValue);

        /// <summary>
        /// Adds of subtracts heights in different units (first value is imperial, second value is metric)
        /// </summary>
        /// <param name="feetValue">Feet value.</param>
        /// <param name="inchesValue">Inches value.</param>
        /// <param name="operation">Operation.</param>
        /// <param name="metersValue">Meters value.</param>
        /// <param name="centimetersValue">Centimeters value.</param>
        /// <returns></returns>
        HeightResultInBothUnits AddHeightIM(decimal feetValue, decimal inchesValue, Operations operation, decimal metersValue, decimal centimetersValue);
    }
}
