using Microsoft.AspNetCore.Mvc;
using swapi_dev_net_core.Models;
using swapi_dev_net_core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace swapi_dev_net_core.Controllers
{
    [Route("/Planets")]
    [ApiController]
    public class PlanetsController : ControllerBase
    {
        private IWebClientService _clientService;
        public PlanetsController(IWebClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<IEnumerable<Planets>> Get()
        {
            return await _clientService.GetPlanets();
        }
        
    }
}