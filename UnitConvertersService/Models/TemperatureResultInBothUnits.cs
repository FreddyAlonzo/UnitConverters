namespace UnitConvertersService.Models
{
    public class TemperatureResultInBothUnits
    {
        public double firstValue { get; set; }
        public TemperatureUnits firstTemperatureUnits { get; set; }
        public double secondValue { get; set; }
        public TemperatureUnits secondTemperatureUnits { get; set; }
    }
}
