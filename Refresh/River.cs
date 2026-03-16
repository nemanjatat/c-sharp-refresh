using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh
{
    internal class River
    {
        public String name;
        public String source;
        public double length;
        public String[] countries;

        public River(String name, String source, double length, String[] countries)
        {
            this.name = name;
            this.source = source;
            this.length = length;
            this.countries = countries;
        }

        public override string ToString()
        {
            String message = "";
            String countryList = "\n";

            for(int i = 0; i < countries.Length; i++)
            {
                countryList += countries[i] + "\n";
            }

            message = $"-- River Info --\nName: {name}\nSource: {source}\nLength: ~{length}km"
                + $"\n-List of countries: {countryList}";
            return message;
        }
    }
}
