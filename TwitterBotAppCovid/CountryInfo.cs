using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterBotAppCovid
{
    public class CountryInfo
    {

        [JsonProperty(PropertyName = "Id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "Iso2")]
        public string Iso2 { get; set; }

        [JsonProperty(PropertyName = "Flagx")]
        public string Flag { get; set; }

    }
}
