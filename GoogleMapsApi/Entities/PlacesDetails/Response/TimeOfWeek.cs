using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace GoogleMapsApi.Entities.PlacesDetails.Response
{
    public class TimeOfWeek
    {
        /// <remarks>
        /// .net's DayOfWeek follows the same numbering as google (Sunday == 0) therefor a specific
        /// conversion step is not needed, the deserializer's direct casting will work.
        /// http://msdn.microsoft.com/en-us/library/system.dayofweek.aspx
        /// </remarks>
        [JsonProperty("day")]
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// May contain a time of day in 24-hour hhmm format (values are in the range 0000–2359). The time will
        /// be reported in the Place's timezone.
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; } = null!;
    }
}
