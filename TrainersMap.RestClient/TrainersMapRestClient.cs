using System.Net.Http;
using System.Threading.Tasks;
using PortableRest;

namespace TrainersMap.RestClient
{
    public class TrainersMapRestClient : PortableRest.RestClient
    {
        private string _apiHost = "http://www.preprod.trainersmap.com.hostingasp.pl";
        public TrainersMapRestClient()
        {
            BaseUrl = _apiHost;
        }

        public async Task<string> GetVersion()
        {
            var request = new RestRequest($"/api/values/version", HttpMethod.Get) { ContentType = ContentTypes.Json };
            return await ExecuteAsync<string>(request);
        }
    }
}
