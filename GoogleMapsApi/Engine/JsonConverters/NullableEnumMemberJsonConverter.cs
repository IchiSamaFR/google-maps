using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Engine.JsonConverters
{
    public class NullableEnumMemberJsonConverter<TEnum> : JsonConverter<TEnum?>
        where TEnum : struct, Enum
    {
        private readonly JsonConverter<TEnum> _innerConverter = new EnumMemberJsonConverter<TEnum>();

        public override TEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return null;
            return _innerConverter.Read(ref reader, typeof(TEnum), options);
        }

        public override void Write(Utf8JsonWriter writer, TEnum? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                _innerConverter.Write(writer, value.Value, options);
            else
                writer.WriteNullValue();
        }
    }
}
