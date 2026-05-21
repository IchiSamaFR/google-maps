using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GoogleMapsApi.Entities.PlacesDetails.Response
{
    public class Aspect
    {
        /// <summary>
        /// Event id.
        /// </summary>
        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = null!;

    }
}
