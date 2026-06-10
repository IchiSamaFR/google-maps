using GoogleMapsApi.Engine.JsonConverters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.PlacesDetails.Response
{
    /// <summary>
    /// Indicates the operational status of the place, if it is a business.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(EnumMemberJsonConverter<BusinessStatus>))]
    public enum BusinessStatus
    {
        /// <summary>
        /// The place is operational.
        /// </summary>
        [EnumMember(Value = "OPERATIONAL")]
        Operational,

        /// <summary>
        /// The place is closed temporarily.
        /// </summary>
        [EnumMember(Value = "CLOSED_TEMPORARILY")]
        ClosedTemporarily,

        /// <summary>
        /// The place is closed permanently.
        /// </summary>
        [EnumMember(Value = "CLOSED_PERMANENTLY")]
        ClosedPermanently
    }
}