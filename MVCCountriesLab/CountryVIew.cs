using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryView
    {
        public Country Country { get; set; }

        public CountryView(Country Country)
        {
            this.Country = Country;
        }

        public void Display()
        {
            Console.WriteLine($"Country Display for {Country.Name}");
            Console.WriteLine($"Country Colors are :");
            for (int i = 0; i < Country.Colors.Count; i++)
            {
                Console.WriteLine($"\t{Country.Colors[i]} \n");
            }
            Console.WriteLine($"Country is located on {Country.Continent}");
        }
    }
}
