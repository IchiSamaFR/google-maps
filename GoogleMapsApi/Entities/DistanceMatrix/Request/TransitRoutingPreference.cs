namespace GoogleMapsApi.Entities.DistanceMatrix.Request
{
    using GoogleMapsApi.Engine.JsonConverters;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [DataContract]
    [JsonConverter(typeof(EnumMemberJsonConverter<DistanceMatrixTransitRoutingPreferences>))]
    public enum DistanceMatrixTransitRoutingPreferences
    {
        // To be used for 'transit' travel mode only
        [EnumMember]
        less_walking, // route should prefer limited amounts of walking
        [EnumMember]
        fewer_transfers, // route should prefer limited numbers of transfers
    }
}