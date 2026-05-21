namespace GoogleMapsApi.Entities.DistanceMatrix.Response
{
    using GoogleMapsApi.Engine.JsonConverters;
    using GoogleMapsApi.Entities.Common;
    using GoogleMapsApi.Entities.DistanceMatrix.Request;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Collections.Generic;

    public class DistanceMatrixResponse : IResponseFor<DistanceMatrixRequest>
    {
        /// <summary>
        /// "status" contains metadata on the request. See Status Codes below.
        /// </summary>
        [JsonPropertyName("status")]
        [JsonConverter(typeof(EnumMemberJsonConverter<StatusCodes>))]
        public StatusCodes Status { get; set; }

        [JsonPropertyName("rows")]
        public IEnumerable<Row> Rows { get; set; } = null!;

        [JsonPropertyName("destination_addresses")]
        public IEnumerable<string> DestinationAddresses { get; set; } = null!;


        [JsonPropertyName("origin_addresses")]
        public IEnumerable<string> OriginAddresses { get; set; } = null!;

        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; } = null!;
    }
}
