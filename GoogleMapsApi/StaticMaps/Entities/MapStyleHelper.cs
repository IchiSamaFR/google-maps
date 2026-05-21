using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
                var array = JArray.Parse(json);
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
        public static List<MapStyleRule> FromJsonArray(JArray jsonArray)
        {
            var rules = new List<MapStyleRule>();

            foreach (var element in jsonArray)
            {
                var rule = new MapStyleRule();

                // Parse elementType
                if (element["elementType"] != null)
                {
                    rule.ElementType = element["elementType"]!.ToString();
                }

                // Parse featureType
                if (element["featureType"] != null)
                {
                    rule.FeatureType = element["featureType"]!.ToString();
                }

                // Parse stylers
                if (element["stylers"] != null && element["stylers"]!.Type == JTokenType.Array)
                {
                    foreach (var stylerElement in element["stylers"]!)
                    {
                        var styler = new MapStyleStyler();

                        if (stylerElement["color"] != null)
                        {
                            styler.Color = stylerElement["color"]!.ToString();
                        }

                        if (stylerElement["visibility"] != null)
                        {
                            styler.Visibility = stylerElement["visibility"]!.ToString();
                        }

                        if (stylerElement["lightness"] != null)
                        {
                            styler.Lightness = stylerElement["lightness"]!.Type == JTokenType.Float || stylerElement["lightness"]!.Type == JTokenType.Integer ? (float?)stylerElement["lightness"] : null;
                        }

                        if (stylerElement["saturation"] != null)
                        {
                            styler.Saturation = stylerElement["saturation"]!.Type == JTokenType.Float || stylerElement["saturation"]!.Type == JTokenType.Integer ? (float?)stylerElement["saturation"] : null;
                        }

                        if (stylerElement["gamma"] != null)
                        {
                            styler.Gamma = stylerElement["gamma"]!.Type == JTokenType.Float || stylerElement["gamma"]!.Type == JTokenType.Integer ? (float?)stylerElement["gamma"] : null;
                        }

                        if (stylerElement["hue"] != null)
                        {
                            styler.Hue = stylerElement["hue"]!.ToString();
                        }

                        if (stylerElement["weight"] != null)
                        {
                            styler.Weight = stylerElement["weight"]!.Type == JTokenType.Integer ? (int?)stylerElement["weight"] : null;
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
