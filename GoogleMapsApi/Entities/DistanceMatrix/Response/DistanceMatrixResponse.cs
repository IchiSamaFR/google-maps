namespace GoogleMapsApi.Entities.DistanceMatrix.Response
{
    using GoogleMapsApi.Engine.JsonConverters;
    using GoogleMapsApi.Entities.Common;
    using GoogleMapsApi.Entities.DistanceMatrix.Request;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.Collections.Generic;

    public class DistanceMatrixResponse : IResponseFor<DistanceMatrixRequest>
    {
        /// <summary>
        /// "status" contains metadata on the request. See Status Codes below.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumMemberJsonConverter<StatusCodes>))]
        public StatusCodes Status { get; set; }

        [JsonProperty("rows")]
        public IEnumerable<Row> Rows { get; set; } = null!;

        [JsonProperty("destination_addresses")]
        public IEnumerable<string> DestinationAddresses { get; set; } = null!;


        [JsonProperty("origin_addresses")]
        public IEnumerable<string> OriginAddresses { get; set; } = null!;

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; } = null!;
    }
}
