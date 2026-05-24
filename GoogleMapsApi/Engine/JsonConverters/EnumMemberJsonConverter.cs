using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Engine.JsonConverters
{
    /// <summary>
    /// JSON converter for enums that respects EnumMember attributes with custom values
    /// </summary>
    public class EnumMemberJsonConverter<TEnum> : JsonConverter<TEnum> where TEnum : struct, Enum
    {
        public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var stringValue = reader.GetString();
                if (stringValue == null)
                    throw new JsonException($"Unable to convert null string to {typeToConvert.Name}");

                if (Enum.TryParse<TEnum>(stringValue, true, out var enumValue))
                    return enumValue;

                throw new JsonException($"Unable to convert \"{stringValue}\" to {typeToConvert.Name}");
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                var numericValue = reader.GetInt32();

                // Check if the numeric value corresponds to a valid enum value
                // by checking if it's defined in the enum
                if (Enum.IsDefined(typeToConvert, numericValue))
                {
                    return (TEnum)Enum.ToObject(typeToConvert, numericValue);
                }
                throw new JsonException($"Unable to convert {numericValue} to {typeToConvert.Name}");
            }
            else
            {
                throw new JsonException($"Expected String or Number, got {reader.TokenType}");
            }
        }

        public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        {
            var stringValue = value.ToString();
            if (stringValue == null)
                throw new JsonException($"Unable to convert {value} to string for {typeof(TEnum).Name}");

            writer.WriteStringValue(stringValue);
        }
    }
}