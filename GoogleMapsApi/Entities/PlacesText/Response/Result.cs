using GoogleMapsApi.Entities.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace GoogleMapsApi.Entities.PlacesText.Response
{
    public class Result
    {
        /// <summary>
        /// name contains the human-readable name for the returned result. For establishment results, this is usually the canonicalized business name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; } = null!;

        [JsonProperty("id")]
        [Obsolete("Use place_id instead.  See https://developers.google.com/places/documentation/search#deprecation for more information.")]
        public string ID { get; set; } = null!;

        [JsonProperty("reference")]
        [Obsolete("Use place_id instead.  See https://developers.google.com/places/documentation/search#deprecation for more information.")]
        public string Reference { get; set; } = null!;

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; } = null!;

        [JsonProperty("types")]
        public string[] Types { get; set; } = null!;

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; } = null!;

        [JsonProperty("place_id")]
        public string PlaceId { get; set; } = null!;

        [JsonProperty("photos")]
        public IEnumerable<Photo> Photos { get; set; } = null!;
    }
}
