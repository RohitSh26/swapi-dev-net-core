using System.Collections.Generic;
using swapi_dev_net_core.Models;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace swapi_dev_net_core.Services
{
    public class WebClientService : IWebClientService
    {
        string BASE_URL = "https://swapi.dev/api/";

        public async Task<IEnumerable<T>> Get<T>(string resourceName)
        {
            return await WebClient.RestHttpClient.GetClient<IEnumerable<T>>(BASE_URL + resourceName + "/", (body) => {

                JObject bodyOject = JObject.Parse(body);

                // map JToken to class object and return
                return bodyOject["results"].ToObject<IEnumerable<T>>();
            });
        }
    }
}