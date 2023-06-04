using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json.Serialization;

namespace testAPI
{
    public class Scan
    {
        [JsonPropertyName("scanTime")]
        public DateTime scanTime { get; set; }
        [JsonPropertyName("db")]
        public string db { get; set; }
        [JsonPropertyName("server")]
        public string server { get; set; }
        [JsonPropertyName("errorCount")]
        public uint errorCount { get; set; }



    }
}
