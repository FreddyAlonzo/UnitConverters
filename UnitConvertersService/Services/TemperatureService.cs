using UnitConvertersService.Models;
using UnitConvertersService.Utils;

namespace UnitConvertersService.Services
{
    public class TemperatureService : ITemperatureService
    {
        public TemperatureResultInBothUnits AddTemperature(double firstValue, TemperatureUnits firstUnit, Operations operation, double secondValue, TemperatureUnits secondUnit)
        {
            return TemperatureUtils.AddTemperature(firstValue, firstUnit, operation, secondValue, secondUnit);
        }

        public TemperatureResponse ConvertTemperature(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo)
        {
            return TemperatureUtils.ConvertTemperature(value, UnitsFrom, UnitsTo);
        }
    }
}
