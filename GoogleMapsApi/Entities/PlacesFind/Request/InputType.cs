using GoogleMapsApi.Engine.JsonConverters;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GoogleMapsApi.Entities.PlacesFind.Request
{
    [JsonConverter(typeof(EnumMemberJsonConverter<InputType>))]
    public enum InputType
    {
		[EnumMember(Value = "textquery")]
        TextQuery,
		[EnumMember(Value = "phonenumber")]
        PhoneNumber
    }
}
