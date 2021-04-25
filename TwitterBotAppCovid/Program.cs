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
using System.IO;
using Tweetinvi;
using System.Diagnostics;

namespace TwitterBotAppCovid
{

    public class Program
    {

        static HttpClient client = new HttpClient();

        public static void ExportToFile(string[] tokenArr)
        {
            File.WriteAllLines(Configurations.tokenPath, tokenArr);
        }

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


        public static int[] GetHex(CountryData country)
        {

            return new int[] { 1, 2};
        }
        
        public static string WriteTweetFormat(CountryData arg, CountryData randomCountry)
        {

            Emoji argFlag = new Emoji(new int[] { 0x1F1E6, 0x1F1F7 });

            string str = $" Cant. de casos por millon en {arg.Country} {argFlag} vs. {randomCountry.Country} " +
                $"{arg.CasesPerOneMillion} ///////// {randomCountry.CasesPerOneMillion}";
            return str;
        }


        static async Task Main()
        {
            Console.WriteLine($"<{DateTime.Now}> - Bot Started");

            RunAsync().GetAwaiter().GetResult();


            Console.WriteLine($"<{DateTime.Now}> - Task Bot Finished");
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

                TwitterClient userClient = new TwitterClient(Configurations.consumerKey, Configurations.consumerSecret);

                //await AuthenticateClientAsync();
                if (!File.Exists(Configurations.tokenPath))
                {
                    // Create a client for your app
                    TwitterClient appClient = new TwitterClient(Configurations.consumerKey, Configurations.consumerSecret);

                    // Start the authentication process
                    var authenticationRequest = await appClient.Auth.RequestAuthenticationUrlAsync();



                    // Go to the URL so that Twitter authenticates the user and gives him a PIN code.
                    Process.Start(new ProcessStartInfo(authenticationRequest.AuthorizationURL)
                    {
                        UseShellExecute = true
                    });

                    // Ask the user to enter the pin code given by Twitter
                    Console.WriteLine("Please enter the code and press enter.");
                    var pinCode = Console.ReadLine();


                    // With this pin code it is now possible to get the credentials back from Twitter
                    var userCredentials = await appClient.Auth.RequestCredentialsFromVerifierCodeAsync(pinCode, authenticationRequest);
                    string[] tokarr = new string[] { userCredentials.AccessToken, userCredentials.AccessTokenSecret };

                    ExportToFile(tokarr);

                    // You can now save those credentials or use them as followed
                    userClient = new TwitterClient(userCredentials);
                    var user = await userClient.Users.GetAuthenticatedUserAsync();

                    Console.WriteLine("Congratulation you have authenticated the user: " + user);
                    Console.Read();
                }
                else
                {
                    string[] readText = File.ReadAllLines(Configurations.tokenPath, Encoding.UTF8);
                    var accessToken = readText[0];
                    var accessSecretToken = readText[1];

                    userClient = new TwitterClient(Configurations.consumerKey, Configurations.consumerSecret, accessToken, accessSecretToken);

                }

                
                var listOfCountries = await GetCountryListAsync("?yesterday&sort");
                Random rand = new Random();
                var randomCountry = listOfCountries[rand.Next(listOfCountries.Count)];
                var argentina = listOfCountries.Where(l => l.Country == "Argentina").FirstOrDefault();

                var finalString = WriteTweetFormat(argentina, randomCountry);

                var tweet = await userClient.Tweets.PublishTweetAsync(finalString);
                


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
