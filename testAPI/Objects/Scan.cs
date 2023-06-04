using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json.Serialization;

namespace testAPI.Objects
{
    public class Scan
    {
        [JsonPropertyName("scanTime")]
        public DateTime ScanTime { get; set; }
        [JsonPropertyName("db")]
        public string DB { get; set; }
        [JsonPropertyName("server")]
        public string Server { get; set; }
        [JsonPropertyName("errorCount")]
        public uint ErrorCount { get; set; }
    }
}
