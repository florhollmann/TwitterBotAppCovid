using System.Configuration;


namespace TwitterBotAppCovid
{
    public class Configurations
    {
        public static string consumerKey = ConfigurationManager.AppSettings["consumerKey"];
        public static string consumerSecret = ConfigurationManager.AppSettings["consumerSecret"];
        public static string accessToken = ConfigurationManager.AppSettings["accessToken"];
        public static string accessSecretToken = ConfigurationManager.AppSettings["accessSecretToken"];
        public static string BearerToken = ConfigurationManager.AppSettings["BearerToken"];
        public static string requestTokenUrl = ConfigurationManager.AppSettings["requestTokenUrl"];
        public static string authorizeUrl = ConfigurationManager.AppSettings["authorizeUrl"];
        public static string authorizeTokenUrl = ConfigurationManager.AppSettings["authorizeTokenUrl"];
        public static string callBackUrl = ConfigurationManager.AppSettings["callBackUrl"];
        public static string tokenPath = ConfigurationManager.AppSettings["tokenPath"];
        public static string csvFlagPath = ConfigurationManager.AppSettings["csvFlagPath"];
        public static string csvVaccinesDataFile = ConfigurationManager.AppSettings["csvVaccinesDataFile"];
    }
}
