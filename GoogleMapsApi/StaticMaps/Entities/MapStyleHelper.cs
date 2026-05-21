using System.Text.Json;
using System;
using System.Collections.Generic;

namespace GoogleMapsApi.StaticMaps.Entities
{
    /// <summary>
    /// Helper class for working with Google Styling Wizard JSON and MapStyleRule objects
    /// </summary>
    public static class MapStyleHelper
    {
        /// <summary>
        /// Creates a list of MapStyleRule objects from Google Styling Wizard JSON
        /// </summary>
        /// <param name="json">The JSON string from Google Styling Wizard</param>
        /// <returns>List of MapStyleRule objects</returns>
        public static List<MapStyleRule> FromJson(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException("JSON cannot be null or empty", nameof(json));

            try
            {
                var array = JsonSerializer.Deserialize<JsonElement>(json);
                return FromJsonArray(array);
            }
            catch (JsonException ex)
            {
                throw new ArgumentException("Invalid JSON format", nameof(json), ex);
            }
        }

        /// <summary>
        /// Creates a list of MapStyleRule objects from Google Styling Wizard JSON array
        /// </summary>
        /// <param name="jsonArray">The JSON array from Google Styling Wizard</param>
        /// <returns>List of MapStyleRule objects</returns>
        public static List<MapStyleRule> FromJsonArray(JsonElement jsonArray)
        {
            var rules = new List<MapStyleRule>();

            foreach (var element in jsonArray.EnumerateArray())
            {
                var rule = new MapStyleRule();

                // Parse elementType
                if (element.TryGetProperty("elementType", out var elementType))
                {
                    rule.ElementType = elementType.GetString();
                }

                // Parse featureType
                if (element.TryGetProperty("featureType", out var featureType))
                {
                    rule.FeatureType = featureType.GetString();
                }

                // Parse stylers
                if (element.TryGetProperty("stylers", out var stylers) && stylers.ValueKind == JsonValueKind.Array)
                {
                    foreach (var stylerElement in stylers.EnumerateArray())
                    {
                        var styler = new MapStyleStyler();

                        if (stylerElement.TryGetProperty("color", out var color))
                        {
                            styler.Color = color.GetString();
                        }

                        if (stylerElement.TryGetProperty("visibility", out var visibility))
                        {
                            styler.Visibility = visibility.GetString();
                        }

                        if (stylerElement.TryGetProperty("lightness", out var lightness))
                        {
                            styler.Lightness = lightness.GetSingle();
                        }

                        if (stylerElement.TryGetProperty("saturation", out var saturation))
                        {
                            styler.Saturation = saturation.GetSingle();
                        }

                        if (stylerElement.TryGetProperty("gamma", out var gamma))
                        {
                            styler.Gamma = gamma.GetSingle();
                        }

                        if (stylerElement.TryGetProperty("hue", out var hue))
                        {
                            styler.Hue = hue.GetString();
                        }

                        if (stylerElement.TryGetProperty("weight", out var weight))
                        {
                            styler.Weight = weight.GetInt32();
                        }

                        rule.Stylers.Add(styler);
                    }
                }

                rules.Add(rule);
            }

            return rules;
        }
    }
}
