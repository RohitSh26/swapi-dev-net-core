using System.Collections.Generic;
using System.Threading.Tasks;
using swapi_dev_net_core.Models;

namespace swapi_dev_net_core.Services
{
    public interface IWebClientService
    {
        public Task<IEnumerable<Planets>> GetPlanets();
    }    
}