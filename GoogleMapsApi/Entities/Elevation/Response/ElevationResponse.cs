using GoogleMapsApi.Engine.JsonConverters;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.Elevation.Request;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoogleMapsApi.Entities.Elevation.Response
{
    public class ElevationResponse : IResponseFor<ElevationRequest>
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(EnumMemberJsonConverter<StatusCodes>))]
        public StatusCodes Status { get; set; }

        [JsonPropertyName("results")]
        public IEnumerable<ElevationResult>? Results { get; set; }


        public override string ToString()
        {
            return string.Format("ElevationResponse - Status: {0}, Results count: {1}", Status, Results != null ? Results.Count() : 0);
        }
    }
}
