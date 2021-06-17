using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryController
    {


        List<Country> CountrydB { get; set; } = new List<Country>();

        public CountryController()
        {
            CountrydB.Add(new Country() { Name = "USA", Colors =new List<string> { "Red","White","Blue"},Continent= Country.Continents.NorthAmerica});
            CountrydB.Add(new Country() { Name = "Australia", Colors = new List<string> { "Red", "White", "Blue" }, Continent = Country.Continents.Australia });
            CountrydB.Add(new Country() { Name = "Russian Federation", Colors = new List<string> { "White", "Blue", "Red" }, Continent = Country.Continents.Europe });
            CountrydB.Add(new Country() { Name = "Germany", Colors = new List<string> { "Black", "Red", "Yellow" }, Continent = Country.Continents.Europe });
            CountrydB.Add(new Country() { Name = "Brazil", Colors = new List<string> { "Green", "Yellow", "Blue" }, Continent = Country.Continents.NorthAmerica });
            CountrydB.Add(new Country() { Name = "China", Colors = new List<string> { "Red", "Yellow"}, Continent = Country.Continents.Asia });
            CountrydB.Add(new Country() { Name = "France", Colors = new List<string> { "White" }, Continent = Country.Continents.Europe });
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountrydB);
            Console.WriteLine("Hello, welcome to our country app. Please select a country from the following list:");
            clv.Display();
            int index = int.Parse(Console.ReadLine());

            CountryAction(CountrydB[index]);
        }

    }
}
