using GoogleMapsApi.Engine.JsonConverters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.Elevation.Response
{
	[DataContract]
    [JsonConverter(typeof(EnumMemberJsonConverter<Status>))]
    public enum Status
	{
		[EnumMember]
		OK, // indicating the API request was successful
		[EnumMember]
		INVALID_REQUEST, // indicating the API request was malformed
		[EnumMember]
		OVER_QUERY_LIMIT, // indicating the requestor has exceeded quota
		[EnumMember]
		REQUEST_DENIED, // indicating the API did not complete the request
		[EnumMember]
		UNKNOWN_ERROR //indicating an unknown error
	}
}
