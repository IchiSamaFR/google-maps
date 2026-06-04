using System;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.Directions.Response
{
    [JsonSerializable(typeof(PointsDecodingException))]
    public class PointsDecodingException : Exception
	{
		public string? EncodedString { get; set; }

		public PointsDecodingException()
		{
		}

		public PointsDecodingException(string message) : base(message)
		{
		}

		public PointsDecodingException(string message, string encodedString, Exception inner) : base(message, inner)
		{
			EncodedString = encodedString;
		}
	}
}