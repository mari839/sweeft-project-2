using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class Country
    {
        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("subregion")]
        public string Subregion { get; set; }

        [JsonPropertyName("latlng")]
        public double[] Latlng { get; set; }

        [JsonPropertyName("area")]
        public double? Area { get; set; }

        [JsonPropertyName("population")]
        public int? Population { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("common")]
        public string Common { get; set; }
    }
}
