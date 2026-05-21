using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GoogleMapsApi.Entities.PlacesDetails.Response
{
    /// <summary>
    /// Contains a summary of the place.
    /// </summary>
    public class PlaceEditorialSummary
    {
        /// <summary>
        /// The language of the previous fields. May not always be present.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; } = null!;

        /// <summary>
        /// A medium-length textual summary of the place.
        /// </summary>
        [JsonProperty("overview")]
        public string Overview { get; set; } = null!;
    }
}