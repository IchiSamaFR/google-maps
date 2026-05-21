using System.Text.Json;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.PlaceAutocomplete.Response
{
    /// <summary>
    /// Identifies a section of description in a PlaceAutocomplete search result
    /// </summary>
    public class Term
    {
        /// <summary>
        /// The text of the term
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = null!;

        /// <summary>
        /// The start position of this term in the description, measured in Unicode characters
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; set; }
    }
}
