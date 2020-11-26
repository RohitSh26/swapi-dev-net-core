using Microsoft.AspNetCore.Mvc;
using swapi_dev_net_core.Models;
using swapi_dev_net_core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace swapi_dev_net_core.Controllers
{
    [Route("/Films")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private IWebClientService _clientService;
        public FilmsController(IWebClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<IEnumerable<Film>> Get()
        {
            return await _clientService.Get<Film>("films");
        }
        
    }
}