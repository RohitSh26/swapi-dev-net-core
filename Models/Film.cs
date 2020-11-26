using System.Collections.Generic;
using Newtonsoft.Json;

namespace swapi_dev_net_core.Models
{
    public class Film : BaseEntity
    {
        [JsonProperty]
        public string Title { get; set; }
    
        [JsonProperty]
        public string EpisodeId { get; set; }

        [JsonProperty]
        public string Director { get; set; }    

        [JsonProperty]
        public ICollection<string> Planets { get; set; }
    }
}