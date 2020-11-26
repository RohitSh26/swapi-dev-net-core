using Newtonsoft.Json;

namespace swapi_dev_net_core.Models
{
	public class Planet : BaseEntity
	{
		[JsonProperty]
		public string Name {get; set;}

		[JsonProperty]
		public string Gravity { get; set; }
	}
}
