using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class Country
    {
        public enum Continents
        {
            NorthAmerica,
            SouthAmerica,
            Asia,
            Europe,
            Australia,
            Africa,
            Antartica
        }

        public string Name { get; set; }

        public Continents Continent {get; set;}

        public List<string> Colors { get; set; }
    }
}
