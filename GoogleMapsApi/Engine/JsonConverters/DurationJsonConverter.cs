using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace GoogleMapsApi.Engine.JsonConverters
{
    public class DurationJsonConverter<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)]
        T> : JsonConverter where T : class, new()
    {
        public override bool CanConvert(Type objectType) => typeof(T).IsAssignableFrom(objectType);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartObject)
                throw new JsonSerializationException($"Expected StartObject, got {reader.TokenType}");

            var duration = new T();
            var valueProperty = typeof(T).GetProperty("Value");
            var textProperty = typeof(T).GetProperty("Text");

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.EndObject) break;

                if (reader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = (string)reader.Value!;
                    reader.Read();

                    if (propertyName == "value" && reader.TokenType == JsonToken.Integer && valueProperty != null)
                        valueProperty.SetValue(duration, TimeSpan.FromSeconds(Convert.ToInt32(reader.Value)));

                    if (propertyName == "text" && reader.TokenType == JsonToken.String && textProperty != null)
                        textProperty.SetValue(duration, (string?)reader.Value);
                }
            }

            return duration;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null) { writer.WriteNull(); return; }

            writer.WriteStartObject();

            var valueProperty = typeof(T).GetProperty("Value");
            var textProperty = typeof(T).GetProperty("Text");

            var timeSpan = (TimeSpan?)valueProperty?.GetValue(value);
            if (timeSpan.HasValue)
            {
                writer.WritePropertyName("value");
                writer.WriteValue((int)Math.Round(timeSpan.Value.TotalSeconds));
            }

            var text = (string?)textProperty?.GetValue(value);
            if (text != null)
            {
                writer.WritePropertyName("text");
                writer.WriteValue(text);
            }

            writer.WriteEndObject();
        }
    }
}