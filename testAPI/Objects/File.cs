using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace testAPI.Objects
{
    public class File
    {
        [JsonPropertyName("filename")]
        public string Name { get; set; }
        [JsonPropertyName("result")]
        public bool Result { get; set; }
        [JsonPropertyName("scantime")]
        public DateTime ScanTime { get; set; }
        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
    }
}
