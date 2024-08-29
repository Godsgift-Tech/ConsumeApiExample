using System.Text.Json.Serialization;

namespace ConsumeApiExample.DTO
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Data
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("first_name")]
        public string first_name { get; set; }

        [JsonPropertyName("last_name")]
        public string last_name { get; set; }

        [JsonPropertyName("avatar")]
        public string avatar { get; set; }
    }

    public class UserDTO
    {
        [JsonPropertyName("data")]
        public Data data { get; set; }

        [JsonPropertyName("support")]
        public Support support { get; set; }
    }

    public class Support
    {
        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("text")]
        public string text { get; set; }
    }
}
