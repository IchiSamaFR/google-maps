#if NET5_0_OR_GREATER
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi.Entities.DistanceMatrix.Response;
using GoogleMapsApi.Entities.Elevation.Response;
using GoogleMapsApi.Entities.Geocoding.Response;
using GoogleMapsApi.Entities.PlaceAutocomplete.Response;
using GoogleMapsApi.Entities.Places.Response;
using GoogleMapsApi.Entities.PlacesDetails.Response;
using GoogleMapsApi.Entities.PlacesFind.Response;
using GoogleMapsApi.Entities.PlacesNearBy.Response;
using GoogleMapsApi.Entities.PlacesText.Response;
using GoogleMapsApi.Entities.TimeZone.Response;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Engine
{
    [JsonSerializable(typeof(DirectionsResponse), TypeInfoPropertyName = "DirectionsResponse")]
    [JsonSerializable(typeof(DistanceMatrixResponse), TypeInfoPropertyName = "DistanceMatrixResponse")]
    [JsonSerializable(typeof(ElevationResponse), TypeInfoPropertyName = "ElevationResponse")]
    [JsonSerializable(typeof(GeocodingResponse), TypeInfoPropertyName = "GeocodingResponse")]
    [JsonSerializable(typeof(PlaceAutocompleteResponse), TypeInfoPropertyName = "PlaceAutocompleteResponse")]
    [JsonSerializable(typeof(PlacesResponse), TypeInfoPropertyName = "PlacesResponse")]
    [JsonSerializable(typeof(PlacesDetailsResponse), TypeInfoPropertyName = "PlacesDetailsResponse")]
    [JsonSerializable(typeof(PlacesFindResponse), TypeInfoPropertyName = "PlacesFindResponse")]
    [JsonSerializable(typeof(PlacesNearByResponse), TypeInfoPropertyName = "PlacesNearByResponse")]
    [JsonSerializable(typeof(PlacesTextResponse), TypeInfoPropertyName = "PlacesTextResponse")]
    [JsonSerializable(typeof(TimeZoneResponse), TypeInfoPropertyName = "TimeZoneResponse")]

    [JsonSerializable(typeof(GoogleMapsApi.Entities.Elevation.Response.Result), TypeInfoPropertyName = "ElevationResult")]
    [JsonSerializable(typeof(GoogleMapsApi.Entities.Geocoding.Response.Result), TypeInfoPropertyName = "GeocodingResult")]
    [JsonSerializable(typeof(GoogleMapsApi.Entities.Places.Response.Result), TypeInfoPropertyName = "PlacesResult")]
    [JsonSerializable(typeof(GoogleMapsApi.Entities.PlacesDetails.Response.Result), TypeInfoPropertyName = "PlacesDetailsResult")]
    [JsonSerializable(typeof(GoogleMapsApi.Entities.PlacesNearBy.Response.Result), TypeInfoPropertyName = "PlacesNearByResult")]
    [JsonSerializable(typeof(GoogleMapsApi.Entities.PlacesText.Response.Result), TypeInfoPropertyName = "PlacesTextResult")]

    [JsonSerializable(typeof(GoogleMapsApi.Entities.Common.Geometry), TypeInfoPropertyName = "Geometry")]

    [JsonSerializable(typeof(GoogleMapsApi.Entities.Common.OpeningHours), TypeInfoPropertyName = "OpeningHours")]

    [JsonSerializable(typeof(GoogleMapsApi.Entities.Common.Distance), TypeInfoPropertyName = "Distance")]

    [JsonSerializable(typeof(GoogleMapsApi.Entities.Common.Duration), TypeInfoPropertyName = "Duration")]

    [JsonSerializable(typeof(IEnumerable<GoogleMapsApi.Entities.Elevation.Response.Result>), TypeInfoPropertyName = "IEnumerableElevationResult")]
    [JsonSerializable(typeof(IEnumerable<GoogleMapsApi.Entities.Geocoding.Response.Result>), TypeInfoPropertyName = "IEnumerableGeocodingResult")]
    [JsonSerializable(typeof(IEnumerable<GoogleMapsApi.Entities.Places.Response.Result>), TypeInfoPropertyName = "IEnumerablePlacesResult")]
    [JsonSerializable(typeof(IEnumerable<GoogleMapsApi.Entities.PlacesDetails.Response.Result>), TypeInfoPropertyName = "IEnumerablePlacesDetailsResult")]
    [JsonSerializable(typeof(IEnumerable<GoogleMapsApi.Entities.PlacesNearBy.Response.Result>), TypeInfoPropertyName = "IEnumerablePlacesNearByResult")]
    [JsonSerializable(typeof(IEnumerable<GoogleMapsApi.Entities.PlacesText.Response.Result>), TypeInfoPropertyName = "IEnumerablePlacesTextResult")]
    public partial class GoogleMapsJsonSerializerContext : JsonSerializerContext
    {
    }
}
#endif