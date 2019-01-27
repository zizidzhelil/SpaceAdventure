using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Core.Models.NeoFeedModels
{
    public class Asteroid
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaPictureUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public double AbsoluteMagnitude { get; set; }

        [JsonProperty("estimated_diameter")]
        public Diameter EstimatedDiameter { get; set; }

        [JsonProperty("is_potentially_hazardous_asteroid")]
        public bool IsPotentiallyHazardousAsteroid { get; set; }

        [JsonProperty("close_approach_data")]
        public List<CloseApproachData> CloseApproachData { get; set; }

        [JsonProperty("is_sentry_object")]
        public bool IsSentryObject { get; set; }

        public DateTime AsteroidSearchDate { get; set; }
    }
}
