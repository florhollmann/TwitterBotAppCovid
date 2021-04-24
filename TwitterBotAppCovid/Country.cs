using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterBotAppCovid
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class CountryData
    {
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }


        [JsonProperty(PropertyName = "CountryInfo")]
        public CountryInfo CountryInfo { get; set; }


        [JsonProperty(PropertyName = "Cases")]
        public int Cases { get; set; }


        [JsonProperty(PropertyName = "TodayCases")]
        public int TodayCases { get; set; }

        [JsonProperty(PropertyName = "Deaths")]
        public int Deaths { get; set; }


        [JsonProperty(PropertyName = "TodayDeaths")]
        public int TodayDeaths { get; set; }


        [JsonProperty(PropertyName = "Recovered")]
        public int Recovered { get; set; }


        [JsonProperty(PropertyName = "TodayRecovered")]
        public int TodayRecovered { get; set; }


        [JsonProperty(PropertyName = "Active")]
        public int Active { get; set; }


        [JsonProperty(PropertyName = "Critical")]
        public int Critical { get; set; }


        [JsonProperty(PropertyName = "CasesPerOneMillion")]
        public double CasesPerOneMillion { get; set; }


        [JsonProperty(PropertyName = "DeathsPerOneMillion")]
        public double DeathsPerOneMillion { get; set; }


        [JsonProperty(PropertyName = "Tests")]
        public int Tests { get; set; }


        [JsonProperty(PropertyName = "TestsPerOneMillion")]
        public int TestsPerOneMillion { get; set; }


        [JsonProperty(PropertyName = "Population")]
        public int Population { get; set; }


        [JsonProperty(PropertyName = "Continent")]
        public string Continent { get; set; }


        [JsonProperty(PropertyName = "OneCasePerPeople")]
        public int OneCasePerPeople { get; set; }


        [JsonProperty(PropertyName = "OneDeathPerPeople")]
        public int OneDeathPerPeople { get; set; }


        [JsonProperty(PropertyName = "OneTestPerPeople")]
        public int OneTestPerPeople { get; set; }


        [JsonProperty(PropertyName = "Populundefinedation")]
        public int Populundefinedation { get; set; }


        [JsonProperty(PropertyName = "ActivePerOneMillion")]
        public double ActivePerOneMillion { get; set; }

        [JsonProperty(PropertyName = "RecoveredPerOneMillion")]
        public double RecoveredPerOneMillion { get; set; }


        [JsonProperty(PropertyName = "CriticalPerOneMillion")]
        public double CriticalPerOneMillion { get; set; }
    }
}
