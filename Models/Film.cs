using System.Collections.Generic;
using Newtonsoft.Json;

namespace swapi_dev_net_core.Models
{
    public class Film
    {
        [JsonProperty]
        public string Title { get; set; }
    
        [JsonProperty]
        public string EpisodeId { get; set; }

        [JsonProperty]
        public string Director { get; set; }    

        [JsonProperty]
        IEnumerable<string> Planets {get; set;}
    }
}