using Newtonsoft.Json;

namespace Core.Models.NeoFeedModels
{
    public class Kilometers
    {
        [JsonProperty("estimated_diameter_min")]
        public double Min { get; set; }

        [JsonProperty("estimated_diameter_max")]
        public double Max { get; set; }
    }
}
