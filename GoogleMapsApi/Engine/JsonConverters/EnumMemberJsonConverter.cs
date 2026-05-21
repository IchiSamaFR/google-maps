using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.Serialization;

namespace GoogleMapsApi.Engine.JsonConverters
{
    public class EnumMemberJsonConverter<TEnum> : JsonConverter where TEnum : struct, Enum
    {
        public override bool CanConvert(Type objectType) => objectType.IsEnum || (Nullable.GetUnderlyingType(objectType)?.IsEnum ?? false);

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                var s = (string?)reader.Value ?? throw new JsonSerializationException($"Unable to convert null string to {objectType.Name}");

                if (Enum.TryParse(s, out TEnum parsedEnum))
                    return parsedEnum;

                throw new JsonSerializationException($"Unable to convert \"{s}\" to {objectType.Name}");
            }

            if (reader.TokenType == JsonToken.Integer)
            {
                var n = Convert.ToInt32(reader.Value);
                if (Enum.IsDefined(typeof(TEnum), n))
                    return (TEnum)Enum.ToObject(typeof(TEnum), n);
                throw new JsonSerializationException($"Unable to convert {n} to {objectType.Name}");
            }

            if (reader.TokenType == JsonToken.Null && Nullable.GetUnderlyingType(objectType) != null) return null;

            throw new JsonSerializationException($"Expected String or Integer, got {reader.TokenType}");
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            writer.WriteValue(value.ToString());
        }
    }
}