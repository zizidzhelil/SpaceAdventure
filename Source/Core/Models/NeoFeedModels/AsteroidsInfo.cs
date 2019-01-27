using Newtonsoft.Json;

namespace Core.Models.NeoFeedModels
{
    public class AsteroidsInfo
    {
        [JsonProperty("element_count")]
        public int ElementCount { get; set; }

        [JsonProperty("near_earth_objects")]
        public NearEarthObjects NearEarthObjects { get; set; }
    }
}
