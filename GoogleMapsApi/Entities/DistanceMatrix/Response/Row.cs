namespace GoogleMapsApi.Entities.DistanceMatrix.Response
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Collections.Generic;

    public class Row
    {
        /// <summary>
		/// element[] The information about each origin-destination pairing is returned in an element entry
		/// </summary>
		[JsonPropertyName("elements")]
        public IEnumerable<Element> Elements { get; set; } = null!;
    }
}
