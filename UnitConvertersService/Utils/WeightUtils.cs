using UnitConvertersService.Models;

namespace UnitConvertersService.Utils
{
    public static class WeightUtils
    {
        public static double ConvertWeightValue(double value, WeightUnits UnitsFrom, WeightUnits UnitsTo)
        {
            if (UnitsFrom == UnitsTo)
                return value;
            else if (UnitsFrom == WeightUnits.Pounds & UnitsTo == WeightUnits.Kilograms)
                return PoundsToKilograms(value);
            else if (UnitsFrom == WeightUnits.Kilograms & UnitsTo == WeightUnits.Pounds)
                return KilogramsToPounds(value);
            else
                throw new ArgumentException();
        }

        public static WeightResponse ConvertWeight(double value, WeightUnits UnitsFrom, WeightUnits UnitsTo)
        {
            WeightResponse weightResponse = new WeightResponse();
            weightResponse.value = ConvertWeightValue(value, UnitsFrom, UnitsTo);
            weightResponse.units = UnitsTo;

            return weightResponse;
        }

        public static WeightResultInBothUnits AddWeight(double firstValue, WeightUnits firstUnit, Operations operation, double secondValue, WeightUnits secondUnit)
        {
            WeightResultInBothUnits resultInBothUnits = new WeightResultInBothUnits();
            double SecondValueFirstUnit = ConvertWeightValue(secondValue, secondUnit, firstUnit);
            double ResultFirstUnit;
            if (operation == Operations.Add)
                ResultFirstUnit = firstValue + SecondValueFirstUnit;
            else if (operation == Operations.Subtract)
                ResultFirstUnit = firstValue - SecondValueFirstUnit;
            else
                throw new ArgumentException();
            resultInBothUnits.firstValue = ResultFirstUnit;
            resultInBothUnits.firstWeightUnits = firstUnit;

            double FirstValueSecondUnit = ConvertWeightValue(firstValue, firstUnit, secondUnit);
            double ResultSecondUnit;
            if (operation == Operations.Add)
                ResultSecondUnit = secondValue + FirstValueSecondUnit;
            else if (operation == Operations.Subtract)
                ResultSecondUnit = FirstValueSecondUnit - secondValue;
            else
                throw new ArgumentException();
            resultInBothUnits.secondValue = ResultSecondUnit;
            resultInBothUnits.secondWeightUnits = secondUnit;

            return resultInBothUnits;
        }

        public static double PoundsToKilograms(double value)
        {
            double Kiligrams = 0.45359237 * value;
            return Kiligrams;
        }

        public static double KilogramsToPounds(double value)
        {
            double Pounds = 2.2046226218 * value;
            return Pounds;
        }
    }
}
