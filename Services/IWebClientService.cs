using System.Collections.Generic;
using swapi_dev_net_core.Models;

namespace swapi_dev_net_core.Services
{
    public interface IWebClientService
    {
        IEnumerable<Planets> GetPlanets();
    }    
}