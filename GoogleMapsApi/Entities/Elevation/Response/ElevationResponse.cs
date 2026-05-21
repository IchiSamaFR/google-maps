using GoogleMapsApi.Engine.JsonConverters;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.Elevation.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoogleMapsApi.Entities.Elevation.Response
{
    public class ElevationResponse : IResponseFor<ElevationRequest>
    {
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumMemberJsonConverter<StatusCodes>))]
        public StatusCodes Status { get; set; }

        [JsonProperty("results")]
        public IEnumerable<Result>? Results { get; set; }


        public override string ToString()
        {
            return string.Format("ElevationResponse - Status: {0}, Results count: {1}", Status, Results != null ? Results.Count() : 0);
        }
    }
}
