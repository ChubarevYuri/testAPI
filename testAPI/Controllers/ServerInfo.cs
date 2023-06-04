using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Serialization;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("service/serviceInfo")]
    public class ServerInfo : Controller
    {
        [HttpGet]
        public Server Get()
        {
            return new Server();
        }

        public class Server
        {

            public Server()
            {
                AppName = Assembly.GetEntryAssembly().GetName().Name;
                Version = Assembly.GetEntryAssembly().GetName().Version.ToString();
                DateUtc = DateTime.UtcNow;
            }

            [JsonPropertyName("AppName")]
            public string AppName { get; }
            [JsonPropertyName("Version")]
            public string Version { get; }
            [JsonPropertyName("DateUtc")]
            public DateTime DateUtc { get; }
        }
    }
}
