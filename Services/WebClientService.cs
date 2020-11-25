using System.Collections.Generic;
using swapi_dev_net_core.Models;
using swapi_dev_net_core.WebClient;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace swapi_dev_net_core.Services
{
    public class WebClientService : IWebClientService
    {
        string BASE_URL = "https://swapi.dev/api/planets/";

        public async Task<IEnumerable<Planets>> GetPlanets()
        {
            return await WebClient.RestHttpClient.GetClient<IEnumerable<Planets>>(BASE_URL, (body) => {

                JObject bodyOject = JObject.Parse(body);

                return bodyOject["results"].Select(b => new Planets {
                    Name = (string)b["name"]
                });
            });
        }
    }
}