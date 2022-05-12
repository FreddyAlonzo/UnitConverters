using UnitConvertersService.Models;
using UnitConvertersService.Utils;

namespace UnitConvertersService.Services
{
    public class WeightService : IWeightService
    {
        public WeightResultInBothUnits AddWeight(double firstValue, WeightUnits firstUnit, Operations operation, double secondValue, WeightUnits secondUnit)
        {
            return WeightUtils.AddWeight(firstValue, firstUnit, operation, secondValue, secondUnit);
        }

        public WeightResponse ConvertWeight(double value, WeightUnits UnitsFrom, WeightUnits UnitsTo)
        {
            return WeightUtils.ConvertWeight(value, UnitsFrom, UnitsTo);
        }
    }
}
