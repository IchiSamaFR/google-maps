using GoogleMapsApi.Entities.PlacesDetails.Response;
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace GoogleMapsApi.Engine.JsonConverters
{
    /// <summary>
    /// JSON converter for PriceLevel enum that handles string number conversion (Newtonsoft version)
    /// </summary>
    public class PriceLevelJsonConverter : JsonConverter<PriceLevel?>
    {
        public override PriceLevel? ReadJson(JsonReader reader, Type objectType, PriceLevel? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            if (reader.TokenType == JsonToken.String)
            {
                var stringValue = (string?)reader.Value;
                if (string.IsNullOrEmpty(stringValue))
                    return null;

                if (int.TryParse(stringValue, out var priceLevelInt) && Enum.IsDefined(typeof(PriceLevel), priceLevelInt))
                    return (PriceLevel)priceLevelInt;
            }
            else if (reader.TokenType == JsonToken.Integer)
            {
                var intValue = Convert.ToInt32(reader.Value, CultureInfo.InvariantCulture);
                if (Enum.IsDefined(typeof(PriceLevel), intValue))
                    return (PriceLevel)intValue;
            }
            else if (reader.TokenType == JsonToken.Float)
            {
                var doubleValue = Convert.ToDouble(reader.Value, CultureInfo.InvariantCulture);
                var truncatedValue = (int)doubleValue;
                if (Enum.IsDefined(typeof(PriceLevel), truncatedValue))
                    return (PriceLevel)truncatedValue;
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, PriceLevel? value, JsonSerializer serializer)
        {
            if (value.HasValue)
            {
                writer.WriteValue(((int)value.Value).ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                writer.WriteNull();
            }
        }
    }
}