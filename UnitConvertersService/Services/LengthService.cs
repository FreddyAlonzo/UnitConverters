using UnitConvertersService.Models;
using UnitConvertersService.Utils;

namespace UnitConvertersService.Services
{
    public class LengthService : ILengthService
    {
        public LengthResultInBothUnits AddLength(double firstValue, LengthUnits firstUnit, Operations operation, double secondValue, LengthUnits secondUnit)
        {
            return LengthUtils.AddLength(firstValue, firstUnit, operation, secondValue, secondUnit);
        }

        public LengthResponse ConvertLength(double value, LengthUnits UnitsFrom, LengthUnits UnitsTo)
        {
            return LengthUtils.ConvertLength(value, UnitsFrom, UnitsTo);
        }
    }
}
