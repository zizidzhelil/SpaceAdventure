using Newtonsoft.Json;

namespace Core.Models.NeoFeedModels
{
    public class Distance
    {
        [JsonProperty("astronomical")]
        public string Astronomical { get; set; }

        [JsonProperty("lunar")]
        public string Lunar { get; set; }

        [JsonProperty("kilometers")]
        public string Kilometers { get; set; }
    }
}