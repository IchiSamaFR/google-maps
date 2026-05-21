namespace GoogleMapsApi.Entities.DistanceMatrix.Response
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.Collections.Generic;

    public class Row
    {
        /// <summary>
		/// element[] The information about each origin-destination pairing is returned in an element entry
		/// </summary>
		[JsonProperty("elements")]
        public IEnumerable<Element> Elements { get; set; } = null!;
    }
}
