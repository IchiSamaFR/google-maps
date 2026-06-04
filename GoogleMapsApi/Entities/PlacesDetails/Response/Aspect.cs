using System;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.PlacesDetails.Response
{
    [JsonSerializable(typeof(Aspect))]
    public class Aspect
    {
        /// <summary>
        /// Event id.
        /// </summary>
        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;

    }
}
