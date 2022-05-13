using UnitConvertersService.Models;

namespace UnitConvertersService.Utils
{
    public static class LengthUtils
    {
        public static double ConvertLengthValue(double value, LengthUnits UnitsFrom, LengthUnits UnitsTo)
        {
            if (UnitsFrom == UnitsTo)
                return value;
            else if (UnitsFrom == LengthUnits.Miles & UnitsTo == LengthUnits.Kilometers)
                return MilesToKilometers(value);
            else if (UnitsFrom == LengthUnits.Kilometers & UnitsTo == LengthUnits.Miles)
                return KilometersToMiles(value);
            else
                throw new ArgumentException();
        }

        public static LengthResponse ConvertLength(double value, LengthUnits UnitsFrom, LengthUnits UnitsTo)
        {
            LengthResponse LengthResponse = new LengthResponse();
            LengthResponse.value = ConvertLengthValue(value, UnitsFrom, UnitsTo);
            LengthResponse.units = UnitsTo;

            return LengthResponse;
        }

        public static LengthResultInBothUnits AddLength(double firstValue, LengthUnits firstUnit, Operations operation, double secondValue, LengthUnits secondUnit)
        {
            LengthResultInBothUnits resultInBothUnits = new LengthResultInBothUnits();
            double SecondValueFirstUnit = ConvertLengthValue(secondValue, secondUnit, firstUnit);
            double ResultFirstUnit;
            if (operation == Operations.Add)
                ResultFirstUnit = firstValue + SecondValueFirstUnit;
            else if (operation == Operations.Subtract)
                ResultFirstUnit = firstValue - SecondValueFirstUnit;
            else
                throw new ArgumentException();
            resultInBothUnits.firstValue = ResultFirstUnit;
            resultInBothUnits.firstLengthUnits = firstUnit;

            double FirstValueSecondUnit = ConvertLengthValue(firstValue, firstUnit, secondUnit);
            double ResultSecondUnit;
            if (operation == Operations.Add)
                ResultSecondUnit = secondValue + FirstValueSecondUnit;
            else if (operation == Operations.Subtract)
                ResultSecondUnit = FirstValueSecondUnit - secondValue;
            else
                throw new ArgumentException();
            resultInBothUnits.secondValue = ResultSecondUnit;
            resultInBothUnits.secondLengthUnits = secondUnit;

            return resultInBothUnits;
        }

        public static double MilesToKilometers(double value)
        {
            double Kiligrams = 1.609344 * value;
            return Kiligrams;
        }

        public static double KilometersToMiles(double value)
        {
            double Pounds = value / 1.609344;
            return Pounds;
        }
    }
}
