using System;
using System.Text.Json.Serialization;

namespace GoogleMapsApi.Entities.Common
{
    [JsonSerializable(typeof(Location))]
    public class AddressLocation : ILocationString
	{
		public string Address { get; private set; }

		public AddressLocation(string address)
		{
			Address = address;
		}

		public string LocationString
		{
			get { return Address; }
		}
	}
}