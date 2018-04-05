using System;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ThisDayInHistory
{
    public class TwitterApiClient
    {
        public const string OauthVersion = "1.0";
        public const string OauthSignatureMethod = "HMAC-SHA1";
        public static HttpClient client = new HttpClient();
        public TwitterApiClient(string uri)
        {
            client.BaseAddress = new Uri(uri);
        }

        public TwitterApiClient()
        {
           
        }

        public async Task<ApiHistoryModel> GetTodaysHistoricalEvents()
        {
            var serializer = new DataContractJsonSerializer(typeof(ApiHistoryModel));
            var data = client.GetStringAsync("http://history.muffinlabs.com/date");
            var model = JsonConvert.DeserializeObject<ApiHistoryModel>(data.Result);
            return model;
        }
    }
}
