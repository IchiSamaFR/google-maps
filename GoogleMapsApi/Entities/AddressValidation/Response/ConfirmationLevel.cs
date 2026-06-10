using GoogleMapsApi.Engine.JsonConverters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.AddressValidation.Response
{
    /// <summary>
    /// Per-component confirmation level returned by the Address Validation API.
    /// </summary>
    [JsonConverter(typeof(EnumMemberJsonConverter<ConfirmationLevel>))]
    public enum ConfirmationLevel
    {
        /// <summary>Default value. This value is unused.</summary>
        [EnumMember(Value = "CONFIRMATION_LEVEL_UNSPECIFIED")] Unspecified,

        /// <summary>The component was confirmed to exist as part of the address.</summary>
        [EnumMember(Value = "CONFIRMED")] Confirmed,

        /// <summary>The component could not be confirmed, but is plausible (e.g. a building number on an unverified street).</summary>
        [EnumMember(Value = "UNCONFIRMED_BUT_PLAUSIBLE")] UnconfirmedButPlausible,

        /// <summary>The component is both unconfirmed and likely wrong.</summary>
        [EnumMember(Value = "UNCONFIRMED_AND_SUSPICIOUS")] UnconfirmedAndSuspicious,
    }
}
