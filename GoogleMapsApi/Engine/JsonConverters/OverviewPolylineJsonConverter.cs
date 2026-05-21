using GoogleMapsApi.Entities.Directions.Response;
using Newtonsoft.Json;
using System;
using System.Reflection;

namespace GoogleMapsApi.Engine.JsonConverters
{
    public class OverviewPolylineJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => typeof(OverviewPolyline).IsAssignableFrom(objectType);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartObject)
                throw new JsonSerializationException($"Expected StartObject, got {reader.TokenType}");

            var polyline = new OverviewPolyline();
            var encodedPointsProperty = typeof(OverviewPolyline).GetProperty("EncodedPoints", BindingFlags.NonPublic | BindingFlags.Instance);

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.EndObject) break;

                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = (string)reader.Value!;
                    reader.Read();

                    if (propertyName == "points" && reader.TokenType == JsonToken.String)
                        encodedPointsProperty?.SetValue(polyline, (string?)reader.Value);
                }
            }

            polyline.OnDeserialized();
            return polyline;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null) { writer.WriteNull(); return; }

            writer.WriteStartObject();

            var encodedPointsProperty = typeof(OverviewPolyline).GetProperty("EncodedPoints", BindingFlags.NonPublic | BindingFlags.Instance);
            var encodedPoints = (string?)encodedPointsProperty?.GetValue(value);

            if (encodedPoints != null)
            {
                writer.WritePropertyName("points");
                writer.WriteValue(encodedPoints);
            }

            writer.WriteEndObject();
        }
    }
}