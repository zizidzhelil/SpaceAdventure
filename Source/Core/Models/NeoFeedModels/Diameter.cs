using Newtonsoft.Json;

namespace Core.Models.NeoFeedModels
{
    public class Diameter
    {
        [JsonProperty("kilometers")]
        public Kilometers Kilometers { get; set; }
    }
}