using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryListView
    {
        public List<Country> CountryList { get; set; }

        public CountryListView(List<Country>countrylist)
        {
            this.CountryList = countrylist;
        }

        public void Display()
        {
            for (int i = 0; i < CountryList.Count; i++)
            {
                Console.WriteLine($"{i} {CountryList[i].Name}");
            }
        }
    }
}
