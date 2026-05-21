using GoogleMapsApi.Engine.JsonConverters;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.PlacesText.Request;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace GoogleMapsApi.Entities.PlacesText.Response
{
    public class PlacesTextResponse : IResponseFor<PlacesTextRequest>
    {
        /// <summary>
        /// "status" contains metadata on the request.
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(EnumMemberJsonConverter<StatusCodes>))]
        public StatusCodes Status { get; set; }

        /// <summary>
        /// "results" contains an array of places, with information about the place. See Place Search Results for information about these results. The Places API returns up to 20 establishment results. Additionally, political results may be returned which serve to identify the area of the request.
        /// </summary>
        [JsonPropertyName("results")]
        public IEnumerable<PlacesTextResult>? Results { get; set; }

        /// <summary>
        /// Contains a token that can be used to return up to 20 additional results. When a next_page_token is returned, it contains the next set of results.
        /// </summary>
        [JsonPropertyName("next_page_token")]
        public string NextPage { get; set; } = null!;
    }
}
