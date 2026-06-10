using GoogleMapsApi.Engine.JsonConverters;
using System;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.Directions.Request
{
	[Flags]
    [JsonConverter(typeof(EnumMemberJsonConverter<AvoidWay>))]
    public enum AvoidWay
	{
		Nothing = 0x0,
		Tolls = 0x1,
		Highways = 0x2,
		Ferries = 0x3,
		Indoor = 0x4
	}
}
