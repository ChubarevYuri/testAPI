using System.Text.Json.Serialization;
using System;

namespace testAPI.Objects
{
    public class Error
    {
        [JsonPropertyName("module")]
        public string Module { get; set; }
        [JsonPropertyName("ecode")]
        public int Code { get; set; }
        [JsonPropertyName("error")]
        public string Text { get; set; }
    }
}
