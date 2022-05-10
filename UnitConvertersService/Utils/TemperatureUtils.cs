using UnitConvertersService.Models;

namespace UnitConvertersService.Utils
{
    public static class TemperatureUtils
    {
        public static double ConvertTemperature(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo)
        {
            if (UnitsFrom == UnitsTo)
                return value;
            else if (UnitsFrom == TemperatureUnits.Celcius & UnitsTo == TemperatureUnits.Fahrenheit)
                return CelciusToFahrenheit(value);
            else if (UnitsFrom == TemperatureUnits.Fahrenheit & UnitsTo == TemperatureUnits.Celcius)
                return FahrenheitToCelcius(value);
            else if (UnitsFrom == TemperatureUnits.Celcius & UnitsTo == TemperatureUnits.Kelvin)
                return CelciusToKelvin(value);
            else if (UnitsFrom == TemperatureUnits.Kelvin & UnitsTo == TemperatureUnits.Celcius)
                return KelvinToCelcius(value);
            else if (UnitsFrom == TemperatureUnits.Fahrenheit & UnitsTo == TemperatureUnits.Kelvin)
                return FahrenheitToKelvin(value);
            else if (UnitsFrom == TemperatureUnits.Kelvin & UnitsTo == TemperatureUnits.Fahrenheit)
                return KelvinToFahrenheit(value);
            else
                throw new ArgumentException();
        }

        public static double CelciusToFahrenheit(double value)
        {
            double Fahrenheit = 9 * value / 5 + 32;
            return Fahrenheit;
        }

        public static double FahrenheitToCelcius(double value)
        {
            double Celcius = 5 * (value - 32) / 9;
            return Celcius;
        }
        
        public static double CelciusToKelvin(double value)
        {
            return value + 273;
        }

        public static double KelvinToCelcius(double value)
        {
            return value - 273;
        }

        public static double FahrenheitToKelvin(double value)
        {
            double Celcius = FahrenheitToCelcius(value);
            return CelciusToKelvin(Celcius);
        }

        public static double KelvinToFahrenheit(double value)
        {
            double Celcius = KelvinToCelcius(value);
            return CelciusToFahrenheit(Celcius);
        }
    }
}
