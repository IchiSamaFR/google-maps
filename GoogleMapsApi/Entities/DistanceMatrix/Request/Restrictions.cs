namespace GoogleMapsApi.Entities.DistanceMatrix.Request
{
    using GoogleMapsApi.Engine.JsonConverters;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [DataContract]
    [JsonConverter(typeof(EnumMemberJsonConverter<DistanceMatrixRestrictions>))]
    public enum DistanceMatrixRestrictions
    {
        [EnumMember]
        tolls,
        [EnumMember]
        highways,
        [EnumMember]
        ferries,
        [EnumMember]
        indoor,
    }
}
