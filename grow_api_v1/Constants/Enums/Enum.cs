using System.Text.Json.Serialization;

namespace grow_api_v1.Constants.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Category
    {   
        Fruit,
        LeafyGreens,
        Legumes,
        Marrow,
        Vegetable
    }

    public enum Season
    {
        Autumn,
        Spring,
        Summer,
        Winter
    }
}