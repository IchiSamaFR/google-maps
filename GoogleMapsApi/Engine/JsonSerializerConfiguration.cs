using GoogleMapsApi.Engine.JsonConverters;
using Newtonsoft.Json;

namespace GoogleMapsApi.Engine
{
    /// <summary>
    /// Provides consistent JsonSerializerOptions configuration for Google Maps API serialization.
    /// This ensures both production and test code use the same JSON serialization settings.
    /// </summary>
    public static class JsonSerializerConfiguration
    {
        /// <summary>
        /// Creates a configured JsonSerializerOptions instance with all necessary converters
        /// for Google Maps API entities.
        /// </summary>
        /// <returns>Configured JsonSerializerSettings instance</returns>
        public static JsonSerializerSettings CreateOptions()
        {
            var options = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
            };

            return options;
        }
    }
}