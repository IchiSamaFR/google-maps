using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GoogleMapsApi.Entities.PlacesFind.Response
{
    public class OpeningHours
    {
        /// <summary>
        ///  is a boolean value indicating if the Place is open at the current time.
        /// </summary>
        [JsonProperty("open_now")]
        public bool OpenNow { get; set; }
    }
}
