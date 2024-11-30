using System;

namespace Task_2
{
    class Converter
    {
        private double UsdRate, EurRate, PlnRate;

        public Converter(double usd, double eur, double pln)
        {
            UsdRate = usd;
            EurRate = eur;
            PlnRate = pln;
        }

        public double ConvertToForeign(double amount, string currency)
        {
            return currency switch
            {
                "usd" => amount / UsdRate,
                "eur" => amount / EurRate,
                "pln" => amount / PlnRate,
                _ => throw new ArgumentException("Неправильна валюта")
            };
        }

        public double ConvertToUah(double amount, string currency)
        {
            return currency switch
            {
                "usd" => amount * UsdRate,
                "eur" => amount * EurRate,
                "pln" => amount * PlnRate,
                _ => throw new ArgumentException("Неправильна валюта")
            };
        }

        static void Main(string[] args)
        {
            Converter converter = new Converter(41.52, 43.93, 10.21);

            Console.WriteLine("Виберіть операцію: 1 - грн в інвалюту, 2 - інвалюта в грн");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть суму:");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Виберіть валюту: usd, eur, pln");
            string currency = Console.ReadLine();

            if (choice == 1)
            {
                Console.WriteLine($"Результат: {converter.ConvertToForeign(amount, currency):F2} {currency}");
            }
            else if (choice == 2)
            {
                Console.WriteLine($"Результат: {converter.ConvertToUah(amount, currency):F2} грн");
            }
            else
            {
                Console.WriteLine("Неправильний вибір");
            }
        }
    }
}
