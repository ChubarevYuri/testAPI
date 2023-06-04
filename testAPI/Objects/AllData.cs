using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace testAPI.Objects
{
    public class AllData
    {
        [JsonPropertyName("scan")]
        public Scan Scan { get; set; }
        [JsonPropertyName("files")]
        public List<File> Files { get; set; }
    }
}
