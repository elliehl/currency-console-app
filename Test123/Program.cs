

namespace Test123
{

    class Program
    {

        private static List<string> validCurrencies = new List<string>
        {
            "gbp", "eur", "usd"
        };

        static void Main(string[] args)
        {
            var rateCalculator = new RateCalculator();

            string startingCurrency = "";
            string targetCurrency = "";
            double value = 0;
            string currencyPrompt = "";

            do
            {
                Console.WriteLine("Please choose a starting currency to convert GBP EUR USD");
                startingCurrency = Console.ReadLine().ToLower();
            } while (!validCurrencies.Contains(startingCurrency));

            var filteredCurrencies = validCurrencies.Where(x => x != startingCurrency);

                foreach (string currency in filteredCurrencies)
                {
                    currencyPrompt += $"{currency.ToUpper()} ";
                }

            do
            {
                Console.WriteLine($"Please choose a target currency {currencyPrompt}");
                    targetCurrency = Console.ReadLine().ToLower();
            } while (!filteredCurrencies.Contains(targetCurrency));

            do
            {
                Console.WriteLine("Please input an amount to be converted");
                    value = Convert.ToDouble(Console.ReadLine());
            } while (value <= 0);





            var result = rateCalculator.ConvertCurrency(startingCurrency, targetCurrency, value);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}


                //    void userValue()
                //    {
                //        string currencyPrompt = "";
                //        foreach (string currency in currencyList)
                //        {
                //            if (currency != startingCurrency)
                //            {
                //                currencyPrompt += $"{currency.ToUpper()} ";
                //            }
                //        }
                //        do
                //        {
                //            Console.WriteLine($"Please choose a target currency {currencyPrompt}");
                //            targetCurrency = Console.ReadLine().ToLower();

                //        } while (targetCurrency == startingCurrency || !currencyList.Contains(targetCurrency));
                //        do
                //        {
                //            Console.WriteLine("Please input an amount to be converted");
                //            userCurrencyValue = Convert.ToDouble(Console.ReadLine());
                //        } while (userCurrencyValue <= 0);
                //    }

                //    do
                //    {



                //    } while (!currencyList.Contains(startingCurrency));
                //}