using GoogleMapsApi.Entities.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace GoogleMapsApi.Entities.PlacesFind.Response
{
    public class Candidate
    {
        // basic fields
        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; } = null!;

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; } = null!;

        [JsonProperty("icon")]
        public string Icon { get; set; } = null!;

        [JsonProperty("id")]
        public string ID { get; set; } = null!;

        [JsonProperty("name")]
        public string Name { get; set; } = null!;

        [JsonProperty("permanently_closed")]
        public bool? PermanentlyClosed { get; set; }

        [JsonProperty("photos")]
        public IEnumerable<Photo> Photos { get; set; } = null!;

        [JsonProperty("place_id")]
        public string PlaceId { get; set; } = null!;

        [JsonProperty("plus_code")]
        public string PlusCode { get; set; } = null!;

        [JsonProperty("scope")]
        public string Scope { get; set; } = null!;

        [JsonProperty("types")]
        public string[] Types { get; set; } = null!;

        // contact fields
        /// <summary>
        /// Place Search returns only open_now; use a Place Details request to get the full opening_hours results.
        /// </summary>
        [JsonProperty("opening_hours")]
        public OpeningHours OpeningHours { get; set; } = null!;

        // atmosphere fields
        [JsonProperty("price_level")]
        public int? PriceLevel { get; set; }

        [JsonProperty("rating")]
        public double? Rating { get; set; }
    }
}
