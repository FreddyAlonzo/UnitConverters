using UnitConvertersService.Models;

namespace UnitConvertersService.Utils
{
    public static class HeightUtils
    {
        public static HeightResponse ConvertToMetric(decimal feetValue, decimal inchesValue)
        {
            decimal inchesTotal = FeetToInches(feetValue) + inchesValue;
            decimal centimetersTotal = InchesToCentimeters(inchesTotal);

            return CentimetersToResponse(centimetersTotal);
        }
        
        public static decimal FeetToInches(decimal feet)
        {
            return feet * 12;
        }

        public static decimal InchesToCentimeters(decimal inchesTotal)
        {
            decimal centimetersTotal = inchesTotal * (decimal)2.54;

            return centimetersTotal;
        }

        public static HeightResponse ConvertToImperial(decimal metersValue, decimal centimetersValue)
        {
            decimal centimetersTotal = MetersToCentimeters(metersValue) + centimetersValue;
            decimal inchesTotal = CentimetersToInches(centimetersTotal);

            return InchesToResponse(inchesTotal);
        }

        public static decimal MetersToCentimeters(decimal meters)
        {
            return meters * 100;
        }

        public static decimal CentimetersToInches(decimal centimetersTotal)
        {
            decimal inchesTotal = centimetersTotal / (decimal)2.54;
            return inchesTotal;
        }

        public static HeightResponse CentimetersToResponse(decimal centimetersTotal)
        {
            HeightResponse heightResponse = new HeightResponse();
            int meters = (int) Math.Floor(centimetersTotal / 100);
            //int centimeters = (int)centimetersTotal % 100;
            int centimeters = (int) Math.Round(centimetersTotal - meters * 100);
            heightResponse.value1 = meters;
            heightResponse.units1 = HeightUnits.Meters;
            heightResponse.value2 = centimeters;
            heightResponse.units2 = HeightUnits.Centimeters;

            return heightResponse;
        }

        public static HeightResponse InchesToResponse(decimal inchesTotal)
        {
            HeightResponse heightResponse = new HeightResponse();
            int feet = (int) Math.Floor(inchesTotal / 12);
            //int inches = (int)inchesTotal % 12;
            int inches = (int) Math.Round(inchesTotal - feet * 12);
            heightResponse.value1 = feet;
            heightResponse.units1 = HeightUnits.Feet;
            heightResponse.value2 = inches;
            heightResponse.units2 = HeightUnits.Inches;

            return heightResponse;
        }
        
        public static HeightResultInBothUnits AddHeightMI(decimal metersValue, decimal centimetersValue, Operations operation, decimal feetValue, decimal inchesValue)
        {
            HeightResultInBothUnits resultInBothUnits = new HeightResultInBothUnits();
            decimal centimetersInput = MetersToCentimeters(metersValue) + centimetersValue;
            decimal inchesInput = FeetToInches(feetValue) + inchesValue;

            decimal SecondValueFirstUnit = InchesToCentimeters(inchesInput);
            decimal ResultFirstUnit;
            if (operation == Operations.Add)
                ResultFirstUnit = centimetersInput + SecondValueFirstUnit;
            else if (operation == Operations.Subtract)
                ResultFirstUnit = centimetersInput - SecondValueFirstUnit;
            else
                throw new ArgumentException();
            HeightResponse MetricValue = CentimetersToResponse(ResultFirstUnit);
            resultInBothUnits.firstValue = MetricValue.value1;
            resultInBothUnits.firstHeightUnits = MetricValue.units1;
            resultInBothUnits.firstValue1 = MetricValue.value2;
            resultInBothUnits.firstHeightUnits1 = MetricValue.units2;

            decimal FirstValueSecondUnit = CentimetersToInches(centimetersInput);
            decimal ResultSecondUnit;
            if (operation == Operations.Add)
                ResultSecondUnit = inchesInput + FirstValueSecondUnit;
            else if (operation == Operations.Subtract)
                ResultSecondUnit = FirstValueSecondUnit - inchesInput;
            else
                throw new ArgumentException();
            HeightResponse ImperialValue = InchesToResponse(ResultSecondUnit);
            resultInBothUnits.secondValue = ImperialValue.value1;
            resultInBothUnits.secondHeightUnits = ImperialValue.units1;
            resultInBothUnits.secondValue1 = ImperialValue.value2;
            resultInBothUnits.secondHeightUnits1 = ImperialValue.units2;

            return resultInBothUnits;
        }

        public static HeightResultInBothUnits AddHeightIM(decimal feetValue, decimal inchesValue, Operations operation, decimal metersValue, decimal centimetersValue)
        {
            HeightResultInBothUnits resultInBothUnits = new HeightResultInBothUnits();
            decimal centimetersInput = MetersToCentimeters(metersValue) + centimetersValue;
            decimal inchesInput = FeetToInches(feetValue) + inchesValue;

            decimal SecondValueFirstUnit = CentimetersToInches(centimetersInput);
            decimal ResultFirstUnit;
            if (operation == Operations.Add)
                ResultFirstUnit = inchesInput + SecondValueFirstUnit;
            else if (operation == Operations.Subtract)
                ResultFirstUnit = inchesInput - SecondValueFirstUnit;
            else
                throw new ArgumentException();
            HeightResponse ImperialValue = InchesToResponse(ResultFirstUnit);
            resultInBothUnits.firstValue = ImperialValue.value1;
            resultInBothUnits.firstHeightUnits = ImperialValue.units1;
            resultInBothUnits.firstValue1 = ImperialValue.value2;
            resultInBothUnits.firstHeightUnits1 = ImperialValue.units2;

            decimal FirstValueSecondUnit = InchesToCentimeters(inchesInput);
            decimal ResultSecondUnit;
            if (operation == Operations.Add)
                ResultSecondUnit = centimetersInput + FirstValueSecondUnit;
            else if (operation == Operations.Subtract)
                ResultSecondUnit = FirstValueSecondUnit - centimetersInput;
            else
                throw new ArgumentException();
            HeightResponse MetricValue = CentimetersToResponse(ResultSecondUnit);
            resultInBothUnits.secondValue = MetricValue.value1;
            resultInBothUnits.secondHeightUnits = MetricValue.units1;
            resultInBothUnits.secondValue1 = MetricValue.value2;
            resultInBothUnits.secondHeightUnits1 = MetricValue.units2;

            return resultInBothUnits;
        }
    }
}
