using GoogleMapsApi.Engine.JsonConverters;
using GoogleMapsApi.Entities.AddressValidation.Response;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi.Entities.DistanceMatrix.Response;
using GoogleMapsApi.Entities.Elevation.Response;
using GoogleMapsApi.Entities.Geocoding.Response;
using GoogleMapsApi.Entities.PlaceAutocomplete.Response;
using GoogleMapsApi.Entities.Places.Response;
using GoogleMapsApi.Entities.PlacesDetails.Response;
using GoogleMapsApi.Entities.PlacesFind.Response;
using GoogleMapsApi.Entities.PlacesNearBy.Response;
using GoogleMapsApi.Entities.PlacesRadar.Response;
using GoogleMapsApi.Entities.PlacesText.Response;
using GoogleMapsApi.Entities.TimeZone.Response;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Engine
{
    [JsonSerializable(typeof(AddressValidationResponse))]
    [JsonSerializable(typeof(DirectionsResponse))]
    [JsonSerializable(typeof(DistanceMatrixResponse))]
    [JsonSerializable(typeof(ElevationResponse))]
    [JsonSerializable(typeof(GeocodingResponse))]
    [JsonSerializable(typeof(PlaceAutocompleteResponse))]
    [JsonSerializable(typeof(PlacesResponse))]
    [JsonSerializable(typeof(PlacesDetailsResponse))]
    [JsonSerializable(typeof(PlacesFindResponse))]
    [JsonSerializable(typeof(PlacesNearByResponse))]
    [JsonSerializable(typeof(PlacesTextResponse))]
    [JsonSerializable(typeof(TimeZoneResponse))]

    [JsonSourceGenerationOptions(
        PropertyNameCaseInsensitive = true)]
    public partial class GoogleMapsJsonSerializerContext : JsonSerializerContext
    {
    }
}