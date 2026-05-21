using GoogleMapsApi.Engine.JsonConverters;
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
using GoogleMapsApi.Entities.PlacesRadar.Response;
using GoogleMapsApi.Entities.PlacesText.Response;
using GoogleMapsApi.Entities.TimeZone.Response;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Engine
{
    [JsonSerializable(typeof(DirectionsResponse))]
    [JsonSerializable(typeof(Leg))]
    [JsonSerializable(typeof(Line))]
    [JsonSerializable(typeof(OverviewPolyline))]
    [JsonSerializable(typeof(PointsDecodingException))]
    [JsonSerializable(typeof(Route))]
    [JsonSerializable(typeof(Step))]
    [JsonSerializable(typeof(Stop))]
    [JsonSerializable(typeof(TransitAgency))]
    [JsonSerializable(typeof(TransitDetails))]
    [JsonSerializable(typeof(Vehicle))]
    [JsonSerializable(typeof(VehicleType))]
    [JsonSerializable(typeof(DistanceMatrixResponse))]
    [JsonSerializable(typeof(Element))]
    [JsonSerializable(typeof(Row))]
    [JsonSerializable(typeof(ElevationResponse))]
    [JsonSerializable(typeof(ElevationResult))]
    [JsonSerializable(typeof(AddressComponent))]
    [JsonSerializable(typeof(FramedLocation))]
    [JsonSerializable(typeof(GeocodingResponse))]
    [JsonSerializable(typeof(GeocodingResult))]
    [JsonSerializable(typeof(LocationType))]
    [JsonSerializable(typeof(MatchedSubstring))]
    [JsonSerializable(typeof(PlaceAutocompleteResponse))]
    [JsonSerializable(typeof(Prediction))]
    [JsonSerializable(typeof(Term))]
    [JsonSerializable(typeof(PlacesResponse))]
    [JsonSerializable(typeof(PlacesResult))]
    [JsonSerializable(typeof(Aspect))]
    [JsonSerializable(typeof(BusinessStatus))]
    [JsonSerializable(typeof(Period))]
    [JsonSerializable(typeof(PlaceEditorialSummary))]
    [JsonSerializable(typeof(PlacesDetailsResponse))]
    [JsonSerializable(typeof(PlacesDetailsResult))]
    [JsonSerializable(typeof(Review))]
    [JsonSerializable(typeof(TimeOfWeek))]
    [JsonSerializable(typeof(Candidate))]
    [JsonSerializable(typeof(PlacesFindResponse))]
    [JsonSerializable(typeof(PlacesNearByResponse))]
    [JsonSerializable(typeof(PlacesNearByResult))]
    [JsonSerializable(typeof(PlacesRadarResult))]
    [JsonSerializable(typeof(PlacesTextResponse))]
    [JsonSerializable(typeof(PlacesTextResult))]
    [JsonSerializable(typeof(TimeZoneResponse))]

    [JsonSerializable(typeof(AddressLocation))]
    [JsonSerializable(typeof(Distance))]
    [JsonSerializable(typeof(Duration))]
    [JsonSerializable(typeof(Geometry))]
    [JsonSerializable(typeof(ILocationString))]
    [JsonSerializable(typeof(Location))]
    [JsonSerializable(typeof(MapsBaseRequest))]
    [JsonSerializable(typeof(OpeningHours))]
    [JsonSerializable(typeof(Photo))]
    [JsonSerializable(typeof(PlusCode))]
    [JsonSerializable(typeof(SignableRequest))]
    [JsonSerializable(typeof(StatusCodes))]
    [JsonSerializable(typeof(LocationType))]
    public partial class GoogleMapsJsonSerializerContext : JsonSerializerContext
    {
    }
}