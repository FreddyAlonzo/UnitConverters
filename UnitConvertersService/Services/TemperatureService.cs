using UnitConvertersService.Models;
using UnitConvertersService.Utils;

namespace UnitConvertersService.Services
{
    public class TemperatureService : ITemperatureService
    {
        public double ConvertTemperature(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo)
        {
            return TemperatureUtils.ConvertTemperature(value, UnitsFrom, UnitsTo);
        }
    }
}
