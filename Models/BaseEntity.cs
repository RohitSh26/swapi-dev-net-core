using System;
using Newtonsoft.Json;

namespace swapi_dev_net_core.Models
{
    public class BaseEntity
    {
        [JsonProperty]
        public string Url { get; set; }

        [JsonProperty]
        public DateTime Created { get; set; }

        [JsonProperty]
        public DateTime Edited { get; set; }
    }
}