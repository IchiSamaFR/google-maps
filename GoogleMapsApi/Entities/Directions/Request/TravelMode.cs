using GoogleMapsApi.Engine.JsonConverters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.Directions.Request
{
    [JsonConverter(typeof(EnumMemberJsonConverter<TravelMode>))]
    public enum TravelMode
	{
		[EnumMember(Value = "DRIVING")]
		Driving,
		[EnumMember(Value = "WALKING")]
		Walking,
		[EnumMember(Value = "BICYCLING")]
		Bicycling,
		[EnumMember(Value = "TRANSIT")]
		Transit
	}
}
