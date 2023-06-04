using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;

namespace testAPI.Controllers
{
    [ApiController]
    [Route("newErrors")]
    public class NewError : ControllerBase
    {
        [HttpPost]
        public string Post()
        {
            try
            {
                Objects.AllData file = StaticMethods.AllData;
                string filename = DateTime.UtcNow.ToString("dd-MM-yyyy_HH-mm-ss") + ".json";
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.Write(JsonSerializer.Serialize(file));
                }
                return string.Empty;
            }
            catch (Exception ex) { return ex.Message; };
        }
    }
}
