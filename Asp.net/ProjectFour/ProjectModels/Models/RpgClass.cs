using System.Text.Json.Serialization;

namespace ProjectModels.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,

        Mage,

        Cleric
    }
}