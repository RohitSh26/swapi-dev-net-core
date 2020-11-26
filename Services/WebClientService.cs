using System.Collections.Generic;
using swapi_dev_net_core.Models;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace swapi_dev_net_core.Services
{
    public class WebClientService : IWebClientService
    {
        string BASE_URL = "https://swapi.dev/api/planets/";

        public async Task<IEnumerable<Planet>> GetPlanets()
        {
            return await WebClient.RestHttpClient.GetClient<IEnumerable<Planet>>(BASE_URL, (body) => {

                JObject bodyOject = JObject.Parse(body);

                // map JToken to class object and return
                return bodyOject["results"].ToObject<IEnumerable<Planet>>();
            });
        }
    }
}