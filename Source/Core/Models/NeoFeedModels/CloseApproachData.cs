using Newtonsoft.Json;

namespace Core.Models.NeoFeedModels
{
    public class CloseApproachData
    {
        [JsonProperty("close_approach_date")]
        public string CloseApproachDate { get; set; }

        [JsonProperty("epoch_date_close_approach")]
        public object EpochDateCloseApproach { get; set; }

        [JsonProperty("relative_velocity")]
        public RelativeVelocity RelativeVelocity { get; set; }

        [JsonProperty("miss_distance")]
        public Distance MissDistance { get; set; }

        [JsonProperty("orbiting_body")]
        public string OrbitingBody { get; set; }
    }
}
