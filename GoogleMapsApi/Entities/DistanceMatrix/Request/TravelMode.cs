namespace GoogleMapsApi.Entities.DistanceMatrix.Request
{
    using GoogleMapsApi.Engine.JsonConverters;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [DataContract]
    [JsonConverter(typeof(EnumMemberJsonConverter<DistanceMatrixTravelModes>))]
    public enum DistanceMatrixTravelModes
    {
        [EnumMember]
        driving, // uses road network.
        [EnumMember]
        walking, // uses pedestrian paths (where available).
        [EnumMember]
        bicycling, // uses bicycle paths and preferred streets (where available).
        [EnumMember]
        transit, // uses public transit routes (where available).
    }
}
