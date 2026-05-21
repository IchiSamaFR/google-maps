using System.Runtime.Serialization;

namespace GoogleMapsApi.Entities.Common
{
    [DataContract]
    public enum StatusCodes
    {
        [EnumMember]
        OK, // indicates the response contains a valid result.

        [EnumMember]
        NOT_FOUND,//indicates at least one of the locations specified in the request's origin, destination, or waypoints could not be geocoded.

        [EnumMember]
        ZERO_RESULTS,// indicates no route could be found between the origin and destination.

        [EnumMember]
        MAX_WAYPOINTS_EXCEEDED, // indicates that too many waypoints were provided in the request. The maximum allowed waypoints is 25, including the origin, destination, and any additional waypoints.

        [EnumMember]
        MAX_ROUTE_LENGTH_EXCEEDED, // indicates the requested route is too long and cannot be processed.

        [EnumMember]
        INVALID_REQUEST, // indicates that the provided request was invalid.

        [EnumMember]
        MAX_ELEMENTS_EXCEEDED, // indicates that the product of origins and destinations exceeds the per-query limit.

        [EnumMember]
        OVER_QUERY_LIMIT, // indicates the service has received too many requests from your application within the allowed time period.

        [EnumMember]
        REQUEST_DENIED, // indicates that the service denied use of the directions service by your application.

        [EnumMember]
        UNKNOWN_ERROR, // indicates a directions request could not be processed due to a server error. The request may succeed if you try again
    }
}
