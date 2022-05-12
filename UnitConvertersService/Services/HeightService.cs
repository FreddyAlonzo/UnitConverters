using UnitConvertersService.Models;
using UnitConvertersService.Utils;

namespace UnitConvertersService.Services
{
    public class HeightService : IHeightService
    {
        public HeightResultInBothUnits AddHeightMI(decimal metersValue, decimal centimetersValue, Operations operation, decimal feetValue, decimal inchesValue)
        {
            return HeightUtils.AddHeightMI(metersValue, centimetersValue, operation, feetValue, inchesValue);
        }

        public HeightResultInBothUnits AddHeightIM(decimal feetValue, decimal inchesValue, Operations operation, decimal metersValue, decimal centimetersValue)
        {
            return HeightUtils.AddHeightIM(feetValue, inchesValue, operation, metersValue, centimetersValue);
        }

        public HeightResponse ConvertHeightToImperial(decimal metersValue, decimal centimetersValue)
        {
            return HeightUtils.ConvertToImperial(metersValue, centimetersValue);
        }

        public HeightResponse ConvertHeightToMetric(decimal feetValue, decimal inchesValue)
        {
            return HeightUtils.ConvertToMetric(feetValue, inchesValue);
        }
    }
}
