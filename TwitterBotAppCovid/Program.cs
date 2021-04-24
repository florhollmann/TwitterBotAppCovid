using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ninject.Activation;
using Microsoft.AspNetCore.Http;


namespace TwitterBotAppCovid
{

    public class Program
    {
        public System.Collections.Specialized.NameValueCollection QueryString { get; }
        static HttpClient client = new HttpClient();
        static CountryData country = new CountryData();

        public static List<T> Deserialize<T>(string SerializedJSONString)
        {
            var listOfCountries = JsonConvert.DeserializeObject<List<T>>(SerializedJSONString);
            return listOfCountries;
        }


        static async Task<List<CountryData>> GetCountryListAsync(string path)
        {
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress + path);

            List<CountryData> listCount = new List<CountryData>();
            if (response.IsSuccessStatusCode)
            {
                var countriesJson = await response.Content.ReadAsStringAsync();
                listCount = Deserialize<CountryData>(countriesJson);
            }

            return listCount;
        }

        static async Task<CountryData> GetCountryAsync(string path)
        {
            CountryData country = null;

            HttpResponseMessage response = await client.GetAsync(client.BaseAddress + path);
            if (response.IsSuccessStatusCode)
            {
                country = await response.Content.ReadAsAsync<CountryData>();
            }
            return country;
        }


        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://corona.lmao.ninja/v2/countries/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                
                var listOfCountries = await GetCountryListAsync("?yesterday&sort");
                

                // Get the countries request
                //country = await GetCountryAsync("?yesterday&sort");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
