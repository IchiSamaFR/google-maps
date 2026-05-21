using GoogleMapsApi.Engine.JsonConverters;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.PlaceAutocomplete.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace GoogleMapsApi.Entities.PlaceAutocomplete.Response
{
    public class PlaceAutocompleteResponse : IResponseFor<PlaceAutocompleteRequest>
    {
        /// <summary>
        /// "status" contains metadata on the request.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumMemberJsonConverter<StatusCodes>))]
        public StatusCodes Status { get; set; }

        /// <summary>
        /// "results" contains an array of predictions rather than full results, each including a description and a reference which can be queried further
        /// to get the full place details
        /// </summary>
        [JsonProperty("predictions")]
        public IEnumerable<Prediction> Results { get; set; } = null!;
    }
}
