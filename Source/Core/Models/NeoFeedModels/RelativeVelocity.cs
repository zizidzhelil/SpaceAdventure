using Newtonsoft.Json;

namespace Core.Models.NeoFeedModels
{
    public class RelativeVelocity
    {
        [JsonProperty("kilometers_per_second")]
        public string KilometersPerSecond { get; set; }

        [JsonProperty("kilometers_per_hour")]
        public string KilometersPerHour { get; set; }
    }
}