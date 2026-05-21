using GoogleMapsApi.Engine.JsonConverters;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.PlacesFind.Request;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace GoogleMapsApi.Entities.PlacesFind.Response
{
    public class PlacesFindResponse : IResponseFor<PlacesFindRequest>
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(EnumMemberJsonConverter<StatusCodes>))]
        public StatusCodes Status { get; set; }

        /// <summary>
        /// Collection of places. Each result contains only the data types that were specified using the fields parameter, plus html_attributions.
        /// </summary>
        [JsonPropertyName("candidates")]
        public IEnumerable<Candidate> Candidates { get; set; } = null!;
    }
}
