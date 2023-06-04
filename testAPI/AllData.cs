using System.Text.Json.Serialization;

namespace testAPI
{
    public class AllData
    {
        [JsonPropertyName("scan")]
        public Scan Scan { get; set; }
    }
}
