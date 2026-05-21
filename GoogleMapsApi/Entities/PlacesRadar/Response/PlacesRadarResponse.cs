using GoogleMapsApi.Engine.JsonConverters;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.PlacesRadar.Request;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace GoogleMapsApi.Entities.PlacesRadar.Response
{
    [Obsolete("Radar search is deprecated since June 30 2018", true)]
    public class PlacesRadarResponse : IResponseFor<PlacesRadarRequest>
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
        public IEnumerable<PlacesRadarResult>? Results { get; set; }
    }
}
