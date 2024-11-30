using System;

namespace Task_1
{
    class Address 
    {
        public int Index { get; set; } // два методи get; set
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = 04053,
                Country = "Україна",
                City = "Київ",
                Street = "Бульварно-Кудрявська",
                House = "18/2",
                Apartment = "15"
            };

            Console.WriteLine($"Адреса: {address.Index}, {address.Country}, {address.City}, {address.Street}, {address.House}, кв. {address.Apartment}");
        }
    }
}
