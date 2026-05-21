using GoogleMapsApi.Entities.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace GoogleMapsApi.Entities.PlacesRadar.Response
{
    public class Result
    {
        [JsonProperty("id")]
        [Obsolete("Use place_id instead.  See https://developers.google.com/places/documentation/search#deprecation for more information.")]
        public string ID { get; set; } = null!;

        [JsonProperty("reference")]
        [Obsolete("Use place_id instead.  See https://developers.google.com/places/documentation/search#deprecation for more information.")]
        public string Reference { get; set; } = null!;

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; } = null!;

        [JsonProperty("place_id")]
        public string PlaceId { get; set; } = null!;
    }
}
