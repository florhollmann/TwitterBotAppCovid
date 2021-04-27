using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterBotAppCovid.Core
{
    public class Country
    {
        public string CountryName { get; set; }
        public double DailyCases { get; set; }
        public string VaccinationNumber { get; set; }
    
    
    
    public Country(string name, double cases, string vaccinesapplied)
        {
            CountryName = name;
            DailyCases = cases;
            VaccinationNumber = vaccinesapplied;
        }
    }
}
