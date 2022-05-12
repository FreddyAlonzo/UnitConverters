using UnitConvertersService.Models;

namespace UnitConvertersService.Utils
{
    public static class TemperatureUtils
    {
        public static double ConvertTemperatureValue(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo)
        {
            if (UnitsFrom == UnitsTo)
                return value;
            else if (UnitsFrom == TemperatureUnits.Celsius & UnitsTo == TemperatureUnits.Fahrenheit)
                return CelsiusToFahrenheit(value);
            else if (UnitsFrom == TemperatureUnits.Fahrenheit & UnitsTo == TemperatureUnits.Celsius)
                return FahrenheitToCelsius(value);
            else if (UnitsFrom == TemperatureUnits.Celsius & UnitsTo == TemperatureUnits.Kelvin)
                return CelsiusToKelvin(value);
            else if (UnitsFrom == TemperatureUnits.Kelvin & UnitsTo == TemperatureUnits.Celsius)
                return KelvinToCelsius(value);
            else if (UnitsFrom == TemperatureUnits.Fahrenheit & UnitsTo == TemperatureUnits.Kelvin)
                return FahrenheitToKelvin(value);
            else if (UnitsFrom == TemperatureUnits.Kelvin & UnitsTo == TemperatureUnits.Fahrenheit)
                return KelvinToFahrenheit(value);
            else
                throw new ArgumentException();
        }

        public static TemperatureResponse ConvertTemperature(double value, TemperatureUnits UnitsFrom, TemperatureUnits UnitsTo)
        {
            TemperatureResponse temperatureResponse = new TemperatureResponse();
            temperatureResponse.value = ConvertTemperatureValue(value, UnitsFrom, UnitsTo);
            temperatureResponse.units = UnitsTo;

            return temperatureResponse;
        }

        public static ResultInBothUnits AddTemperature(double firstValue, TemperatureUnits firstUnit, Operations operation, double secondValue, TemperatureUnits secondUnit)
        {
            ResultInBothUnits resultInBothUnits = new ResultInBothUnits();
            double SecondValueFirstUnit = ConvertTemperatureValue(secondValue, secondUnit, firstUnit);
            double ResultFirstUnit;
            if (operation == Operations.Add)
                ResultFirstUnit = firstValue + SecondValueFirstUnit;
            else if (operation == Operations.Subtract)
                ResultFirstUnit = firstValue - SecondValueFirstUnit;
            else
                throw new ArgumentException();
            resultInBothUnits.firstValue = ResultFirstUnit;
            resultInBothUnits.firstTemperatureUnits = firstUnit;

            double FirstValueSecondUnit = ConvertTemperatureValue(firstValue, firstUnit, secondUnit);
            double ResultSecondUnit;
            if (operation == Operations.Add)
                ResultSecondUnit = secondValue + FirstValueSecondUnit;
            else if (operation == Operations.Subtract)
                ResultSecondUnit = FirstValueSecondUnit - secondValue;
            else
                throw new ArgumentException();
            resultInBothUnits.secondValue = ResultSecondUnit;
            resultInBothUnits.secondTemperatureUnits = secondUnit;

            return resultInBothUnits;
        }

        public static double CelsiusToFahrenheit(double value)
        {
            double Fahrenheit = 9 * value / 5 + 32;
            return Fahrenheit;
        }

        public static double FahrenheitToCelsius(double value)
        {
            double Celcius = 5 * (value - 32) / 9;
            return Celcius;
        }
        
        public static double CelsiusToKelvin(double value)
        {
            return value + 273;
        }

        public static double KelvinToCelsius(double value)
        {
            return value - 273;
        }

        public static double FahrenheitToKelvin(double value)
        {
            double Celcius = FahrenheitToCelsius(value);
            return CelsiusToKelvin(Celcius);
        }

        public static double KelvinToFahrenheit(double value)
        {
            double Celcius = KelvinToCelsius(value);
            return CelsiusToFahrenheit(Celcius);
        }
    }
}
