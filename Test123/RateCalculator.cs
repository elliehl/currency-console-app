using System;

namespace Test123
{
    public class RateCalculator
    {
        private Dictionary<string, double> poundsConversionRates = new Dictionary<string, double>();
        private Dictionary<string, double> eurosConversionRates = new Dictionary<string, double>();
        private Dictionary<string, double> dollarsConversionRates = new Dictionary<string, double>();

        public RateCalculator()
        {
            poundsConversionRates.Add("eur", 1.16);
            poundsConversionRates.Add("usd", 1.28);
            eurosConversionRates.Add("gbp", 0.86);
            eurosConversionRates.Add("usd", 1.11);
            dollarsConversionRates.Add("gbp", 0.78);
            dollarsConversionRates.Add("eur", 0.90);
        }

        public double ConvertCurrency(string startingCurrency, string targetCurrency, double value)
        {
            switch (startingCurrency)
            {
                case "gbp":
                    return Math.Round(value * poundsConversionRates[targetCurrency], 2);
                case "eur":
                    return Math.Round(value * eurosConversionRates[targetCurrency], 2);
                case "usd":
                    return Math.Round(value * dollarsConversionRates[targetCurrency], 2);
                default:
                    return 0;
            }
        }
    }
    }
