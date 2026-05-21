using GoogleMapsApi.Engine.JsonConverters;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.PlacesFind.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace GoogleMapsApi.Entities.PlacesFind.Response
{
    public class PlacesFindResponse : IResponseFor<PlacesFindRequest>
    {
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumMemberJsonConverter<StatusCodes>))]
        public StatusCodes Status { get; set; }

        /// <summary>
        /// Collection of places. Each result contains only the data types that were specified using the fields parameter, plus html_attributions.
        /// </summary>
        [JsonProperty("candidates")]
        public IEnumerable<Candidate> Candidates { get; set; } = null!;
    }
}
