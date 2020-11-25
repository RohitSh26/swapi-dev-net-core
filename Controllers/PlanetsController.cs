using Microsoft.AspNetCore.Mvc;
using swapi_dev_net_core.Services;
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
        
    }
}