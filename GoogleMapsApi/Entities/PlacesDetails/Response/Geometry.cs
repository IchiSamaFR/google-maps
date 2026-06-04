using System.Text.Json.Serialization;
using GoogleMapsApi.Entities.Common;

namespace GoogleMapsApi.Entities.PlacesDetails.Response
{
    /// <summary>
    /// Contains the location
    /// </summary>
    [JsonSerializable(typeof(Geometry))]
    public class Geometry
    {
        [JsonPropertyName("location")]
        public Location Location { get; set; } = null!; 
    }
}