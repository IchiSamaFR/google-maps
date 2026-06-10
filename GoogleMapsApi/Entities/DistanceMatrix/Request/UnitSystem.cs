namespace GoogleMapsApi.Entities.DistanceMatrix.Request
{
    using GoogleMapsApi.Engine.JsonConverters;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [DataContract]
    [JsonConverter(typeof(EnumMemberJsonConverter<DistanceMatrixUnitSystems>))]
    public enum DistanceMatrixUnitSystems
    {
        [EnumMember]
        metric, // kilometers an meters.
        [EnumMember]
        imperial, // miles and feet.
    }
}
