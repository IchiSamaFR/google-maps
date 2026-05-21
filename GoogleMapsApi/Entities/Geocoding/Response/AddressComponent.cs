using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace GoogleMapsApi.Entities.Geocoding.Response
{
    public class AddressComponent
    {
        /// <summary>
        /// types[] is an array indicating the type of the address component.
        /// </summary>
        [JsonProperty("types")]
        public IEnumerable<string> Types { get; set; } = null!;
        /// <summary>
        /// short_name is an abbreviated textual name for the address component, if available. For example, an address component for the state of Alaska may have a long_name of "Alaska" and a short_name of "AK" using the 2-letter postal abbreviation.
        /// </summary>
        [JsonProperty("short_name")]
        public string ShortName { get; set; } = null!;
        /// <summary>
        /// long_name is the full text description or name of the address component as returned by the Geocoder.
        /// </summary>
        [JsonProperty("long_name")]
        public string LongName { get; set; } = null!;

    }
}
